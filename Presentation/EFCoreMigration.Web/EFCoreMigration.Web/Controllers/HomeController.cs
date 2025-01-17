﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCoreMigration.Web.Models;

namespace EFCoreMigration.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
            #region 反编译之后的结果
            //ErrorViewModel errorViewModel = new ErrorViewModel();
            //Activity activity = Activity.Current;
            //errorViewModel.RequestId = (((activity != null) ? activity.Id : null) ?? base.HttpContext.TraceIdentifier);
            //return this.View(errorViewModel);
            #endregion
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
