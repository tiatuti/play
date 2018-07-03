using MyShop.Data;
using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Services
{
    public class ShopInitializer : IShopInitializer
    {
        ShopDbContext shopContext;
        public ShopInitializer(ShopDbContext shopContext)
        {
            this.shopContext = shopContext;
        }
        public void Initialize()
        {
            shopContext.Database.EnsureDeleted();
            shopContext.Database.EnsureCreated();

            if (shopContext.Products.Any())
            {
                return;
            }

            shopContext.Products.Add(
              new Product()
              {
                  Name = "Yoghurt",
                  ImageName = "yogurt.jpg",
                  Description = "Its freshness will melt you.",
                  Price = 3.5M
              });
            shopContext.Products.Add(
              new Product()
              {
                  Name = "Banana",
                  ImageName = "banana.jpg",
                  Description = "Great for a snack.",
                  Price = 1.2M
              });
            shopContext.SaveChanges();
        }
    }
}
