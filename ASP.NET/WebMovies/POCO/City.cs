using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebMovies
{
      public class City
    {
          [Key]
          [Required]
          public int IDcity { get; set; }


          [StringLength(10)]
          [Required]
          public string NameCity { get; set; }

          public virtual ICollection<FilmScreening> FilmScreening { get; set; }
    }
}
