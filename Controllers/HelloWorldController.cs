﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/id

        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = id;

            return View();
        }
    }
}