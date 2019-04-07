using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebMovies;
 
namespace WebMovies
{
    
    public class FilmScreening
    {
        [Key]
        [Required]
        public int IDFilmScreening { get; set; }

       
        [Required]
        public virtual City IDcity { get; set; }

        [Required]
        public DateTime DataTime { get; set; }

        [Required]
        public virtual Movies MoviesID { get; set; }
       

    }
}