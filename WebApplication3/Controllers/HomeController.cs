using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Entities;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {


        private readonly IProductRepository _context;
        public HomeController(IProductRepository context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.GetAllAsync());
        }


        [HttpGet]

        public IActionResult Add()
        {
            var product = new Product();
            return View(product);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
            }
            return View();
        }


        [HttpGet]

        public IActionResult Update(int id)
        {
            var updatedProduct = _context.GetAllAsync().Result.FirstOrDefault(c => c.Id == id);
            return View(updatedProduct);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Update(product);
                return Redirect("/home/index");
            }

            return View(product);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deletedProduct = _context.GetAllAsync().Result.FirstOrDefault(c => c.Id == id);
            _context.Delete(deletedProduct);

            return Redirect("/home/index");
        }
    }
}
