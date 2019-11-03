using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySuperMarket.BLL.BusinessObjects
{
    public class ProductBO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int CurrentPrice { get; set; }
        [Required]
        public int StockAvailable { get; set; }
    }
}
