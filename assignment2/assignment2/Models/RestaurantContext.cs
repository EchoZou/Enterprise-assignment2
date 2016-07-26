//Name: COMP2007 Enterprise Computing Assignment 2  - Summer 2016
//Author: Mo Zou &¡¡Pui in Kwok 
//Description: This assignment is a MVC restaurant website which is built by MVC framework. There are home, menu, menu manager, 
//contact, register and login pages. User need to register or login to see the menu manager page from navbar.

namespace assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantConnect")
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }

    
    }
}
