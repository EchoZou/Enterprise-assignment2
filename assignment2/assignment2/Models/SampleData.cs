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
            var genres = new List<Genre>
            {
                new Genre { Name = "Appetizer" },
                new Genre { Name = "Main Course" },
                new Genre { Name = "Desserts" },
                new Genre { Name = "Beverages" }
            };

            

            new List<Item>
            {
                new Item { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Worlds", Genre = genres.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "For Those About To Rock We Salute You", Genre = genres.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Let There Be Rock", Genre = genres.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Balls to the Wall", Genre = genres.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Restless and Wild", Genre = genres.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Górecki: Symphony No. 3", Genre = genres.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Big Ones", Genre = genres.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Quiet Songs", Genre = genres.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                new Item { Title = "Jagged Little Pill", Genre = genres.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/placeholder.gif" },
                
            }.ForEach(a => context.Items.Add(a));
        }
    }
}