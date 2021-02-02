using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt_ASP.NET.Models;

namespace Projekt_ASP.NET.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public ViewResult List(string category) => View(productRepository.Products.Where(p => p.Category == category));
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetById(int id)
        {
            Product tmp = productRepository.Products.First(x => x.ID == id);
            return View(tmp);
        }
    }
}
