using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_ASP.NET.Models
{
    public class EFProductRepository : IProductRepository
    {

        private readonly AppDbContext ctx;
        public EFProductRepository(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<Product> Products => ctx.Products;
        public void saveProduct(Product product)
        {
            if (product.ID == 0)
            {
                ctx.Products.Add(product);

            }
            else
            {
                Product temp = ctx.Products.First(x => x.ID == product.ID);
                if (temp != null)
                {
                    temp.Name = product.Name;
                    temp.Price = product.Price;
                    temp.Category = product.Category;
                    temp.Description = product.Description;
                }

            }
            ctx.SaveChanges();
        }
        public void deleteProduct(int productID)
        {
            Product temp = ctx.Products.First(x => x.ID == productID);
            if (temp != null)
            {
                ctx.Products.Remove(temp);
                ctx.SaveChanges();
            }
        }
    }
}
