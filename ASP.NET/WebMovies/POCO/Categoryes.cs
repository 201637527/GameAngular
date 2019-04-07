using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; 
namespace WebMovies
{
   public class Categoryes
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }

        [Required]
        
        public string Description { get; set; }
        public virtual ICollection<Movies> Movies { get; set; }
       
    }
}
