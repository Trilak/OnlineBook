﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Write()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Shelf()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}