using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersmanagementSeeSkills.POCO
{
    
   
    
      class DbContextentity :  DbContext
      {
          public DbContextentity()
              : base("SkillEmp")
 
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbContextentity>());
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Ref> Reference { get; set; }
        public virtual DbSet<SkillIdInfo> SkillIdInfo { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }


    }

}
