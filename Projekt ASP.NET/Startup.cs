using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Projekt_ASP.NET.Extensions;
using Projekt_ASP.NET.Models;
using System.Reflection;
using System.IO;
using Microsoft.OpenApi.Models;
using Projekt_ASP.NET.SignalR.Hubs;
using Amazon.EC2.Model;

namespace Projekt_ASP.NET
{
    
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
        Configuration = configuration;
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddRazorPages();
            services.AddSignalR();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration["Data:SportStoreProducts:ConnectionString"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseElapsedTimeMiddleware();
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "api";
            });
            app.UseAuthentication();
            app.UseDeveloperExceptionPage(); // informacje szczeg�owe o b��dach
            app.UseStatusCodePages(); // Wy�wietla strony ze statusem b��du
            app.UseStaticFiles(); // obs�uga tre�ci statycznych css, images, js
            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
            app.UseAuthorization();
            app.UseEndpoints(routes => {
                routes.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=List}/{id?}");
                routes.MapControllerRoute(
                    name: null,
                    pattern: "Product/{category}",
                    defaults: new
                    {
                        controller = "Product",
                        action = "List",
                    });
                routes.MapControllerRoute(
                    name: null,
                    pattern: "{controller=Admin}/{action=Index}");
                routes.MapHub<ChatHub>("/chathub");
                routes.MapHub<Counter>("/counter");
            }) ;
            SeedData.EnsurePopulated(app);
        }
    }
}
