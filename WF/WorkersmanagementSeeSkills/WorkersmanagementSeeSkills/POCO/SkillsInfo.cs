using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WorkersmanagementSeeSkills.POCO
{
    class SkillIdInfo
    {
        [Key]
        public int SkillInfoId { get; set; }

        [Required]
        [StringLength(250)]
        public string URL { get; set; }

        public int SkillId { get; set; }

        public virtual Skills Skills { get; set; }
    }
}
