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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MvcWebUI.Extensions;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class AdminController : Controller

    {
        NorthwindContext c = new NorthwindContext();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Admin admin)
        {
            
            var logger = c.Users.FirstOrDefault(x => x.Email == admin.Email && x.Pass == admin.Pass);
            HttpContext.Session.SetObject("logger", logger);
            return View();

        }
    }
}