using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace WebMovies
{
    public class Manger
    {
        [Key]
        [Required]
        public int MangerID { get; set; }

        
        [Required]
        public string MangerName { get; set; }

        [Required]
       
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
    
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
      
        public string UserName { get; set; }
    }
}