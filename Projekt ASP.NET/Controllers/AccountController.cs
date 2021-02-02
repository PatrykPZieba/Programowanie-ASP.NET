using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projekt_ASP.NET.Migrations;
using Projekt_ASP.NET.Models;
using WebApplication2.Seeder;

namespace Projekt_ASP.NET.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            IdentitySeedData.EnsurePopulated(_userManager).Wait();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByNameAsync(loginModel.name);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    if((await _signInManager.PasswordSignInAsync(user, loginModel.password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.returnUrl ?? "/Admin/Index");
                    }
                }
            }
            ModelState.AddModelError("", "nieprawidłowe dane logowania");
            return View(loginModel);

        }
        [AllowAnonymous]
        public ViewResult Login(string returnUrl){
            return View(new LoginModel {returnUrl=returnUrl });
        }
        public async Task<IActionResult> Logout(string returnUrl="/")
        {
            await _signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }
    }
}
