using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentOnProductsManagement.Models;

namespace AssignmentOnProductsManagement.Controllers
{
    public class ProductController : Controller
    {
        public static List<Products> li = new List<Products>()
        {
            new Products() { Pid=110001,Pname="Headphones",Price=299,Stock=10 }
        };
        public IActionResult Index()
        {
            return View(li);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Products p)
        {
            if (ModelState.IsValid)
            {
                li.Add(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
        }
    }
}
