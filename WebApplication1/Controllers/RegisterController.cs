using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DataAccess.Contcrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MvcWebUI.Models;
using Microsoft.EntityFrameworkCore;
using MvcWebUI.Extensions;

namespace MvcWebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegisterViewModel _model;
        public RegisterController(RegisterViewModel model)
        {
            _model = model;
        }
        [HttpGet]
        public IActionResult RegisterIndex()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterIndex(Register register)
        {

            _model.Add(register);
            _model.SaveChanges();
            ViewBag.message = "The user " + register.Username + " is saved successfully !";
            return View();

        }
    }
}

