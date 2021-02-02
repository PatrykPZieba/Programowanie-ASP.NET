using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_ASP.NET.Models
{
    public class LoginModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        [UIHint("password")]
        public string password { get; set; }
        public string returnUrl { get; set; } = "/";
    }
}
