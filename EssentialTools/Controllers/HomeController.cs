using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products =
        {
            new Product { Name = "Каяк", Category = "Водные виды спорта", Price =275M },

            new Product {Name = "Спасательный жилет", Category = "Водные виды спорта", Price = 48.95M},

            new Product {Name = "Мяч", Category = "Футбол", Price = 19.50M},

            new Product {Name = "Угловой флажок", Category = "Футбол", Price = 34.95M}
        };

        public ActionResult Index()
        {
            LinqValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc)
            {
                Products = products
            };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}