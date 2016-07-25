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
            var menus = new List<Menu>
            {
                new Menu { Name = "Appetizer" },
                new Menu { Name = "Main Course" },
                new Menu { Name = "Desserts" },
                new Menu { Name = "Beverages" }
            };

            

            new List<Item>
            {
                new Item { Title = "A Copland Celebration, Vol. I", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Worlds", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "For Those About To Rock We Salute You", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Let There Be Rock", Menu = menus.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Balls to the Wall", Menu = menus.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Restless and Wild", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Górecki: Symphony No. 3", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Big Ones", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Quiet Songs", Menu = menus.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Jagged Little Pill", Menu = menus.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                
            }.ForEach(a => context.Items.Add(a));
        }
    }
}