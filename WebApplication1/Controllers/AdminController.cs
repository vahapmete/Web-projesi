using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccess.Contcrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcWebUI.Extensions;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class AdminController : Controller

    {
        NorthwindContext c = new NorthwindContext();
        
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
        {
            var logger = c.Users.FirstOrDefault(x => x.Email == admin.Email && x.Pass == admin.Pass);
            
            if (logger != null)
            {
                HttpContext.Session.SetObject("logger", logger);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.Email)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("HomeIndex", "Home");
            }
            
            
            return View();

        }
    }
}