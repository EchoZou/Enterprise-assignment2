//Name: COMP2007 Enterprise Computing Assignment 2  - Summer 2016
//Author: Mo Zou &　Pui in Kwok 
//Description: This assignment is a MVC restaurant website which is built by MVC framework. There are home, menu, menu manager, 
//contact, register and login pages. User need to register or login to see the menu manager page from navbar.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace assignment2.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            //menu schema
            var menus = new List<Menu>
            {
                new Menu { Name = "Appetizer" },
                new Menu { Name = "Main Course" },
                new Menu { Name = "Desserts" },
                new Menu { Name = "Beverages" }
            };

            //item schema
            new List<Item>
            {
                
                new Item { Title = "Seaweed Salad", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Tofu soup", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "New York Steak", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Noodles", Menu = menus.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Fried Rice", Menu = menus.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Mango ice cream", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Matcha ice cream", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Red bean ice cream", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Pop", Menu = menus.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Coffee", Menu = menus.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                
            }.ForEach(a => context.Items.Add(a));
        }
    }
}