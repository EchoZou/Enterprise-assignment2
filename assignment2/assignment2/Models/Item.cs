namespace assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public int ItemID { get; set; }

        public int MenuID { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string DetailedDescription { get; set; }

        public decimal Price { get; set; }

        public string URL { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
