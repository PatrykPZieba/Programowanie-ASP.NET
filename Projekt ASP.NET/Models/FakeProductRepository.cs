using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_ASP.NET.Models
{
    public class FakeProductRepository : IProductRepository
    {

        public IQueryable<Product> Products => new List<Product>
            {
                new Product {ID=1, Name = "Ein",Description="Ein",Price=1000000,Category="Banan"},
                new Product {ID=2, Name = "Zwei",Description="Ein",Price=1000000,Category="Banan"},
                new Product {ID=3, Name = "Drei",Description="Ein",Price=1000000,Category="Banan"}
            }.AsQueryable<Product>();

        public void deleteProduct(int productID)
        {
            throw new NotImplementedException();
        }

        public void saveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
