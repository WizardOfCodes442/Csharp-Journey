/**
This file is the default controller added by microsoft visual studio 
when you select the web template creating and asp core package
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers {
    public class HomeController : Controller{
        public IActionResult Index() {
            return View();
        }
        public IActionResult About(){
            ViewData["Message"] = "Your Application Description Page";

            return View();
        }
        public IActionResult Error() {
            return View();
        }

    }

}