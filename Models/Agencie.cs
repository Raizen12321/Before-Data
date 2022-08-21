using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ImmoBook.Models
{
    public class Agencie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Agencies")]
        public string LogoURL { get; set; } 
        
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }



        //Relationships
        public List<Property> Properties { get; set; }


    }
}
