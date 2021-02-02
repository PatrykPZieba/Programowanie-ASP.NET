using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt_ASP.NET.Models;

namespace Projekt_ASP.NET.Controllers
{
    [Route("api/[controller]")]
    public class APIController : ControllerBase
    {

        private readonly EFProductRepository repo;
        public APIController(AppDbContext ctx)
        {

            this.repo = new EFProductRepository(ctx);
        }
        [HttpGet]
        public ActionResult<List<Product>> List()
        {
            return Ok(repo.Products.AsEnumerable().ToList());
        }
        [HttpDelete]
        public ActionResult deleteProduct(int productID)
        {
            Product temp = repo.Products.First(x => x.ID == productID);
            if (temp != null)
            {
                repo.deleteProduct(productID);

            }
            return NoContent();
        }
        [HttpGet("{productID}")]
        public ActionResult<List<Product>> Produkt(int productID)
        {
            Product temp = repo.Products.First(x => x.ID == productID);

            return Ok(temp);
        }
        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            repo.saveProduct(product);
            return CreatedAtAction(nameof(Produkt), new { productID = product.ID }, product);
        }
        [HttpPut("{ID}")]
        public ActionResult<Product> editProcuct(int ID, Product product)
        {
            if (ID != product.ID) return BadRequest();
            repo.saveProduct(product);

            return AcceptedAtAction(nameof(Produkt), new { id = product.ID }, product);
        }
    }
}
