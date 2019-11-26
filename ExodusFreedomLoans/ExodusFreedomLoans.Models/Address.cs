using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExodusFreedomLoans.Models
{
    class Address
    {
        [Required]
        [Display(Name= ("Street Address"))]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public int HousingType { get; set; }
    }
}
