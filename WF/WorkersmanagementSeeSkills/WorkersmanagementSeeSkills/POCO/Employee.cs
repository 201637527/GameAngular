using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WorkersmanagementSeeSkills.POCO
{
    class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<Ref> References { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
