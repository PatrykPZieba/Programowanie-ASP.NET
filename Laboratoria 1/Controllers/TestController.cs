using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratoria_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoria_1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string ShowDate()
        {
            DateTime now = DateTime.Now;
            string NowTime = now.ToString("F");
            return NowTime;

        }
        public IActionResult Redirect()
        {
            return Redirect("https://www.google.pl");
        }
        public IActionResult Product()
        {
            var model = new List<ProductModel>
            {
               new ProductModel{ProductName ="Buty Sportowe" , ProductDescription="Wytrzymale buty przeznaczone do biegania na kazdej nawierzchni" , ProductPrice=300},
               new ProductModel{ProductName ="Sweter" , ProductDescription="Sweter na chlodne dni" , ProductPrice=150},
               new ProductModel{ProductName ="Dresy" , ProductDescription="Spodnie dresowe" , ProductPrice=50}
            }; 
            return View(model);
        }
    }
}
