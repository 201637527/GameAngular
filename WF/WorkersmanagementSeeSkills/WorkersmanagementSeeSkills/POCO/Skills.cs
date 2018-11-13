using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WorkersmanagementSeeSkills.POCO
{
    class Skills
    {
        [Key]
        public int SkillId { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string SkilName { get; set; }

        [Required]
        public string BriefDescription { get; set; }

        public virtual Employee Employees { get; set; }

        public virtual ICollection<SkillIdInfo> SkillIdInfo { get; set; }
    }
}
