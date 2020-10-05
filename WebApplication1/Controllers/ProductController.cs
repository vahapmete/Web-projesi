using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Contcrete.EntityFramework.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext db= new NorthwindContext();
        public IActionResult ProductList()
        {
            var values = db.TblProducts.ToList();
            return View(values);
        }
    }
}
