using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Services;

namespace MyShop.Controllers
{
    public class BasketController : Controller
    {
        BasketManager basket;
        public BasketController(BasketManager basket)
        {
            this.basket = basket;
        }

        public IActionResult Index()
        {
            var contents = basket.GetProducts();
            return View(contents);
        }

        public IActionResult AddProduct(int id)
        {
            basket.AddProduct(id);
            return RedirectToAction("Index", "Home");
        }
    }
}