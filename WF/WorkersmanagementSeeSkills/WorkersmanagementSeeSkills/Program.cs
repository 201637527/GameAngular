using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkersmanagementSeeSkills.POCO;

namespace WorkersmanagementSeeSkills
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSkillsdata());

            //DbContextentity m = new DbContextentity();
            //Employees em = new Employees() { FirsName = "almog", LastName = "10", Email = "20", Alias = "30" };
            //Employees emp1 = new Employees() { FirsName = "royi", LastName = "elazar", Email = "100@", Alias = "royko" };
            //m.Employees.Add(em);
            //m.Employees.Add(emp1);
            //m.SaveChanges();
            //DAL.DataAccesslayer.Open();

           

        }
    }
}
