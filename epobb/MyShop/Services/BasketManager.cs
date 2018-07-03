using Microsoft.AspNetCore.Http;
using MyShop.Data;
using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Services
{
    public class BasketManager
    {
        IHttpContextAccessor contextAccessor;
        ShopDbContext shopContext;
        public BasketManager(IHttpContextAccessor contextAccessor, ShopDbContext shopContext)
        {
            this.contextAccessor = contextAccessor;
            this.shopContext = shopContext;
        }


        const string BASKET_KEY = "basket";
        const char SEPARATOR = ',';
        public void AddProduct(int id)
        {
            var ids = GetIds();
            var newIds = ids.ToList();
            newIds.Add(id.ToString());
            string newIdsAsString = newIds.Aggregate(
                (a, b) => a + SEPARATOR + b);
            contextAccessor.HttpContext.Session
                .SetString(BASKET_KEY, newIdsAsString);
        }

        IEnumerable<string> GetIds()
        {
            var current = contextAccessor.HttpContext.Session
                .GetString(BASKET_KEY);
            if (current == null)
            {
                return Enumerable.Empty<string>();
            }
            var ids = current.Split(SEPARATOR);
            return ids;
        }

        public IEnumerable<Product> GetProducts()
        {
            var ids = GetIds();
            var products = shopContext.Products
              .Where(p => ids.Contains(p.ID.ToString()));
            return products;
        }

    }
}
