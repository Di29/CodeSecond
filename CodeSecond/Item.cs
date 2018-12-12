namespace CodeSecond
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}
