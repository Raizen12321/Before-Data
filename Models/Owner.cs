using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ImmoBook.Models
{
    public class Owner
    {

        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        //Relationships

        public List<Property> Properties { get; set; }

    }
}
