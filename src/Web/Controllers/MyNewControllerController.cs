using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MyNewControllerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult mytext()
        {
            return Content("text");
        }
        public IActionResult myjson()
        {
            return Json(new { name = "json",desc = "this is json" });
        }
        public IActionResult myhtml()
        {
            return Content("<htm> <body> this is html </body></html>","text/html");
        }
        public IActionResult myview()
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