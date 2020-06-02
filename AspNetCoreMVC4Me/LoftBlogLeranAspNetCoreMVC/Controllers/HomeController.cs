using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoftBlogLeranAspNetCoreMVC.Models;

namespace LoftBlogLeranAspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HelloModel _model = new HelloModel() { HelloMessage = "Hi my friend!" };
            return View(_model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application discription page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
