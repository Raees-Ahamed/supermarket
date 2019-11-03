using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySuperMarket.DAL.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        [MaxLength(60)]
        public string Description { get; set; }
        [Required]
        public int CurrentPrice { get; set; }
        [Required]
        public int StockAvailable { get; set; }
    }
}
