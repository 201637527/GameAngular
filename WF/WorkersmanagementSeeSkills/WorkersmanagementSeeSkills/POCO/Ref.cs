using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WorkersmanagementSeeSkills.POCO
{

    class Ref
    {
        [Key]
        public int ReferenceId { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string Psition { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employees { get; set; }
    }
}
