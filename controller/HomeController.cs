using Microsoft.AspNetCore.Mvc;
using System;

namespace First2App.controller
{
    public class HomeController:Controller
    {
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting=saat>12?"iyi günler":"günaydın";
            ViewBag.UserName="alp";
            return View();
        }
    }
}