using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ImmoBook.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }
        

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        
        
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Contact")]
        public string Contact { get; set; }

        public List<Property_Agent> Properties_Agents { get; set; }

    }
}
