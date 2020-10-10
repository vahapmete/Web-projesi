using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Contcrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Mvc;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext db= new NorthwindContext();
        public IActionResult ProductList(int page=1)
        {
            var values = db.TblProducts.ToList().ToPagedList(page,10);
            return View(values);
        }

        

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product product)
        {
            product.DateTime = DateTime.Now;
            db.TblProducts.Add(product);
            db.SaveChanges();
            return View();
        }

        public IActionResult Delete(int id)
        {
            var product = db.TblProducts.Find(id);
            db.TblProducts.Remove(product);
            db.SaveChanges();
            return RedirectToAction("ProductList","Product");

        }

        public IActionResult GetProduct(int id)
        {
            var product = db.TblProducts.Find(id);
            return View("GetProduct",product);

        }

        public IActionResult Update(Product p1)
        {
            var product = db.TblProducts.Find(p1.ProductId);
            product.ProductName = p1.ProductName;
            product.ProductCode = p1.ProductCode;
            product.Explain = p1.Explain;
            product.Price = p1.Price;
            product.InStock = p1.InStock;
            db.SaveChanges();
            return RedirectToAction("ProductList", "Product");
        }
    }
}
