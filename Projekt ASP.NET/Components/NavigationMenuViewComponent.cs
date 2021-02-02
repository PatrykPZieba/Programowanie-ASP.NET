using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt_ASP.NET.Models;

namespace Projekt_ASP.NET.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IProductRepository repository;
        public NavigationMenuViewComponent(IProductRepository _repository)
        {
            repository = _repository;
        }
        public IViewComponentResult Invoke()
        {
            
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products.Select(x =>x.Category).Distinct().OrderBy(x => x));
        }
        

    }
}
