using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessObjectLayer.Entities;
using System.Diagnostics;

namespace Market.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using(var context = new MarketContext())
            {
                List<Trader> list = context.Trader.ToList();
                foreach(Trader item in list)
                {
                    Debug.WriteLine("Ime Trejderja je : " + item.Name);
                }
            }
             return View();
           
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            if (User.Identity.IsAuthenticated)
            {
                Debug.WriteLine("Uporabnik " + User.Identity.Name + " je loginan !!!");
            }else
            {
                Debug.WriteLine("User ni loginan !!!");
            }

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
