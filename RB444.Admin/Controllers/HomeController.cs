﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RB444.Admin.Models;
using RB444.Data.Entities;
using System.Diagnostics;

namespace RB444.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
      //  private readonly UserManager<Users> _userManager;

        //public HomeController(UserManager<Users> userManager)
        //{
        //    _userManager = userManager;
        //}

        public ActionResult Index()
        {
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
