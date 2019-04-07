using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace WebMovies
{
    public class Customer
    {
        [Key]
        public int CustomertrID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameCustomer { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(10)]
        public string Pasword { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.CreditCard)]
        [StringLength(50)]
        [Required]
        public string CardToBages { get; set; }

        [StringLength(50)]
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
       

    }
}