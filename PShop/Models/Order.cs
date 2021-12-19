using PShop.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PShop.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string Userid { get; set; }

        public string items { get; set; }

        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DataType(DataType.Text)]
        public string Address { get; set; }

        [DataType(DataType.Text)]
        public string Zip { get; set; }

        public List<Item> Itemlist { get; set; }
    }
}
