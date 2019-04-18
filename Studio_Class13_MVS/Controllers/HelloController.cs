using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Studio_Class13_MVS.Controllers
{
   
    public class HelloController : Controller
    { 
        private string htmlFrom = @"<form method='get' action='/Hello/index'>";

        [HttpGet]
        public IActionResult Index()
        {
            return Content("Some sort of content");
        }
    }
}