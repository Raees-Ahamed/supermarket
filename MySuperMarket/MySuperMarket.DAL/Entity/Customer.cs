using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySuperMarket.DAL.Entity
{
    public class Customer : IdentityUser
    {
        [Required]
        [StringLength(256)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(256)]
        public string LastName { get; set; }
        [Required]
        public int TelephoneNumber { get; set; }
        [Required]
        [StringLength(256)]
        public string Address { get; set; }

    }
}
