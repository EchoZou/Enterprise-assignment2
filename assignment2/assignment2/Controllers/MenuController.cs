//Name: COMP2007 Enterprise Computing Assignment 2  - Summer 2016
//Author: Mo Zou &　Pui in Kwok 
//Description: This assignment is a MVC restaurant website which is built by MVC framework. There are home, menu, menu manager, 
//contact, register and login pages. User need to register or login to see the menu manager page from navbar.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assignment2.Models;

namespace assignment2.Controllers
{
    public class MenuController : Controller
    {
        RestaurantContext storeDB = new RestaurantContext();

        
        // GET: menu/
        public ActionResult Index()
        {
            List<Menu> menus = storeDB.Menus.ToList();

            return View(menus);
        }
      
        // GET: /Menu/Browse?menu=Appetizer

        public ActionResult Browse(string menu = "Appetizer")
        {
            // Retrieve Menu and its Associated items from database
            Menu menuModel = storeDB.Menus.Include("Items").Single(g => g.Name == menu);

            return View(menuModel);
        }
      
        // GET: /Menu/Details

        public ActionResult Details(int id = 1)
        {
            Item item = storeDB.Items.Find(id);

            return View(item);
        }
    }
}