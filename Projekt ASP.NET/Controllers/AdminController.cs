using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt_ASP.NET.Models;

namespace Projekt_ASP.NET.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository bazaProduktow;
        public IActionResult Index()
        {
            return View(bazaProduktow.Products);
           
        }
        public AdminController(IProductRepository repo)
        {
            this.bazaProduktow = repo;
        }
        public IActionResult Edit(int productID)
        {
            Product tmp = bazaProduktow.Products.First(x => x.ID == productID);
            
            return View(tmp);

        }
        [HttpPost]
        public IActionResult Save(Product product)
        {
            if (ModelState.IsValid)
            {
                bazaProduktow.saveProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["message"] = "podane parametry nie są ok";
                return View("Edit", product);
            }
        }
        public IActionResult Create()
        {
            Product product = new Product();
            return View("Edit", product);
        }
        [HttpPost]
        public IActionResult Delete(int productID)
        {
            bazaProduktow.deleteProduct(productID);
            TempData["message"] = "produkt usunięty";
            return RedirectToAction("Index");
        }
    }
}
