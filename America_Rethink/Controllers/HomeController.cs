using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using America_Rethink.Models;
using America_Rethink.Repositories;

namespace America_Rethink.Controllers
{
    public class HomeController : Controller
    {
        public  IActionResult Index()
        {
            PageRepository repo = new PageRepository();

            HomeModel model = new HomeModel
            {
                Logo = true,
                Text = repo.GetPage("HomePage").ToString(),
                Stuff = repo.PageRepo()
            };


            return View(model);
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
