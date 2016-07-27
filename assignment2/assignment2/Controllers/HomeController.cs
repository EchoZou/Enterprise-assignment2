//Name: COMP2007 Enterprise Computing Assignment 2  - Summer 2016
//Author: Mo Zou &　Pui in Kwok 
//Description: This assignment is a MVC restaurant website which is built by MVC framework. There are home, menu, menu manager, 
//contact, register and login pages. User need to register or login to see the menu manager page from navbar.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {            
            return View();
        }
    }
}