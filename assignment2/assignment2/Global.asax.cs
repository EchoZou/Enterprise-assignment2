//Name: COMP2007 Enterprise Computing Assignment 2  - Summer 2016
//Author: Mo Zou &　Pui in Kwok
//Description: This assignment is a MVC restaurant website which is built by MVC framework. There are home, menu, menu manager,
//contact, register and login pages. User need to register or login to see the menu manager page from navbar.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace assignment2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer( new assignment2.Models.SampleData());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
