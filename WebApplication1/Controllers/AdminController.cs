using System.Linq;
using DataAccess.Contcrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Extensions;

namespace WebApplication1.Controllers
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
            if (logger != null && admin.Email==logger.Email && admin.Pass==logger.Pass)
            {
               return RedirectToAction("HomeIndex", "Home");
            }
            return View();
        }
    }
}