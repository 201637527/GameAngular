using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMovies
{
    public class Orders
    {
        [Key]
        [Required]
        public int IDOrders { get; set; }
        public virtual Movies IDMovies { get; set; }

        public virtual Customer  IDCustomer { get; set; }

        public virtual FilmScreening IDfillScreeninge { get; set; }

           



    }
}