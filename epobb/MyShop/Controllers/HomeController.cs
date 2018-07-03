using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Data;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(
            [FromServices] ShopDbContext shopContext,
            string searchString)
        {
            var products = shopContext.Products
                .Where(p =>
                    string.IsNullOrEmpty(searchString)
                    || p.Name.Contains(searchString))
                .OrderBy(p => p.Name)
                .Take(10);
            return View(products);
        }

        public IActionResult Detail(
            [FromServices] ShopDbContext shopContext,
            int id)
        {
            var found = shopContext.Products
                .Where(p => p.ID == id)
                .FirstOrDefault();
            return View(found);
        }

        public IActionResult Image(
            [FromServices] ShopDbContext shopContext, int id)
        {
            var found = shopContext
                .Products
                .Where(p => p.ID == id).FirstOrDefault();
            if (found == null)
            {
                return NotFound();
            }

            var fileName = string.Format(
                "~/images/{0}", found.ImageName);

            return File(fileName, "image/jpeg");
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
