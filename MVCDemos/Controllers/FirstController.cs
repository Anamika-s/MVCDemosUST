using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemos.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "Hello";
            ViewData["message"] = "Passed through ViewData";
            return View();
        }

        public IActionResult Method1()
        {
            return View();
        }
    }
}
