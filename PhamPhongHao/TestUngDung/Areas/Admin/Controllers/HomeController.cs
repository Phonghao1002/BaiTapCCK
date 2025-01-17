﻿using ModelEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Areas.Admin.Models;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            var session = (LoginModel)Session[Constants.USER_SESSTION];
            if (session == null) { return RedirectToAction("Index", "Login"); }
            return View();
        }
        public ActionResult Logout()
        {
            Session[Constants.USER_SESSTION] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}