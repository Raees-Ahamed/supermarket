using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySuperMarket.BLL.BusinessObjects
{
    public class CustomerBO
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int TelephoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
