using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Pole musi zawierać od 2 do 60 znaków"),
        Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Pole musi zawierać od 3 do 60 znaków")]
        public string ZipCode { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Pole musi zawierać od 3 do 60 znaków")]
        public string City { get; set; }

        public int Number { get; set; }
    }
}

