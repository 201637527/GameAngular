using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebMovies;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace WebMovies
{
    public class Movies
    {
        [Key]
        [Required]
        public int MoviesID { get; set; }

        [StringLength(50)]
        [Required]
        public string NameMovies { get; set; }

        [MaxLength]
        [Required]
        [Column(TypeName = "ntext")]
        public string ImageUrlOfMovies { get; set; }

        [Required]  
        public string MovieDirector { get; set; }

        [Required]
       
        public string Description { get; set; }

        
        public int Inventory { get; set; }

        
        public int CategoryID { get; set; }

        public virtual ICollection<FilmScreening> FilmScreening { get; set; }
        public int Rating { get; set; }

        public int CuntRating { get; set; }

    
    }
}