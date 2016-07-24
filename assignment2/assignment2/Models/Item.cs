using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment2.Models
{
    public class Item
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public Item(string Title)
        {
            this.Title = Title;
        }

        public virtual int ItemID { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string Title { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string DetailedDescription { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string URL { get; set; }
        public virtual Genre Genre { get; set; }
    }
}