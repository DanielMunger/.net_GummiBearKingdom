using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKingdom.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Country { get; set; }
        public byte[] Picture { get; set; }
        public Product()
        {

        }

        public Product(string name, int cost, string country, byte[] picture)
        {
            Name = name;
            Cost = cost;
            Country = country;
            Picture = picture;
        }
    }
}
