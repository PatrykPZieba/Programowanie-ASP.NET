#pragma checksum "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\Test\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f986d2ea704361f556caf31c6013ef2ab83097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Product), @"mvc.1.0.view", @"/Views/Test/Product.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\_ViewImports.cshtml"
using Laboratoria_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\_ViewImports.cshtml"
using Laboratoria_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f986d2ea704361f556caf31c6013ef2ab83097", @"/Views/Test/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273da5d6f9bf9bc5eaf19279c04639796260c080", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\Test\Product.cshtml"
  
    ViewData["Title"] = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Product List</h1> \r\n\r\n");
#nullable restore
#line 7 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\Test\Product.cshtml"
 foreach (var m in @Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 9 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\Test\Product.cshtml"
Write(m.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 9 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\Test\Product.cshtml"
               Write(m.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cena wynosi: ");
#nullable restore
#line 9 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\Test\Product.cshtml"
                                                    Write(m.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zl</p>\r\n");
#nullable restore
#line 10 "C:\Users\Anachrox\source\repos\PatrykPZieba\Programowanie-ASP.NET\Laboratoria 1\Views\Test\Product.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591