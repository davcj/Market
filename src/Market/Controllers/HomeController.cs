using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessObjectLayer.Users;

namespace Market.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Trader trader = new Trader();
             trader.username = "sad";
             trader.password = "adasdsd";
             trader.balance = 1000;
             return View(trader);
           
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
