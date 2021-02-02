using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP.NET.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(10000)]
        public string Description { get; set; }
        [Required,Range(1,10000000)]
        public decimal Price { get; set; }
        [Required, StringLength(100)]
        public string Category { get; set; }
        

    }
}
