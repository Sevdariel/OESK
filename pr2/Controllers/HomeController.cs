using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pr1.Extensions;
using pr2.Models;

namespace pr2.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        public IActionResult Index()
        {
            var text = Extension.GetDataURL("wwwroot/images/185B.png");
            ViewBag.ImageData = text;

            return View();
        }

[Route("1kB")]
        public IActionResult Site1kB()
        {
            var text = Extension.GetDataURL("wwwroot/images/1kB.png");
            ViewBag.ImageData = text;

            return View();
        }

        [Route("10kB")]
        public IActionResult Site10kB()
        {
            var text = Extension.GetDataURL("wwwroot/images/10kB.jpg");
            ViewBag.ImageData = text;

            return View();
        }

                [Route("100kB")]
        public IActionResult Site100kB()
        {
            var text = Extension.GetDataURL("wwwroot/images/100kB.jpg");
            ViewBag.ImageData = text;

            return View();
        }

        [Route("1MB")]
        public IActionResult Site1MB()
        {
            var text = Extension.GetDataURL("wwwroot/images/1MB.jpg");
            ViewBag.ImageData = text;

            return View();
        }

               [Route("10MB")]
        public IActionResult Site10MB()
        {
            var text = Extension.GetDataURL("wwwroot/images/10MB.jpg");
            ViewBag.ImageData = text;

            return View();
        }

        
               [Route("100MB")]
        public IActionResult Site100MB()
        {
            var text = Extension.GetDataURL("wwwroot/images/100MB.jpg");
            ViewBag.ImageData = text;

            return View();
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
