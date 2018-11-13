using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkersmanagementSeeSkills.DAL;
using WorkersmanagementSeeSkills.POCO;

namespace WorkersmanagementSeeSkills
{
    public partial class FrmSkillsdata : Form
    {
        private BiznizLogincs.BiznizLogincs bz = new BiznizLogincs.BiznizLogincs();
      
           
        public FrmSkillsdata()
        {
            InitializeComponent();
            //Create  DATABASE
            //DbContextentity m = new DbContextentity();
            //Employee em = new Employee() { FirstName = "almog", LastName = "10", Email = "20", Alias = "30" };
            //Employee emp1 = new Employee() { FirstName = "royi", LastName = "elazar", Email = "100@", Alias = "royko" };
            //m.Employees.Add(em);
            //m.Employees.Add(emp1);
            //m.SaveChanges();
            //DAL.DataAccesslayer.Open();
            
        }
        private void Login()
        {
            linklblURL.Text = "";
            linklblURL.Visible = true;
            dgvemp.DataSource = bz.Selectemp();
            dgvskill.DataSource = bz.Selectskill();
            dgvemp.CurrentRow.Selected = true;
            dgvskill.CurrentRow.Selected = true;
            dgvemp.Columns["EmployeeID"].Visible = false;
            dgvskill.Columns["EmployeeID"].Visible = false;
            dgvskill.Columns["SkillId"].Visible = false;
            txtSelectALLinfo.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login();
         
        }



        private void dgvemp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int EmployeeID = Convert.ToInt32(dgvemp.CurrentRow.Cells[0].Value);

            dgvskill.DataSource = bz.SeleIDemp(EmployeeID);
            txtSelectALLinfo.Clear();

            linklblURL.Visible = false;
            string skillName = "";
            string brif = "";

            if ((dgvskill.RowCount > 1))
            {

                skillName = dgvskill.CurrentRow.Cells[2].Value.ToString();
                brif = dgvskill.CurrentRow.Cells[3].Value.ToString();
                txtSelectALLinfo.Text = "Skill Name:  " + skillName + "\r\n" + "BriefDescription" + "\r\n" + brif;
                int id = Convert.ToInt32(dgvskill.CurrentRow.Cells[0].Value);
                string db;
                bool urlNullOrno = bz.SelURL(id, out db);
                linklblURL.Text = "";
                if (!(urlNullOrno))
                {
                    linklblURL.Visible = true;
                    linklblURL.Text = db;
                }

            }
          
            
            string refskill=bz.SelRrf(Convert.ToInt32(dgvemp.CurrentRow.Cells[0].Value)).TrimStart();
            if (!(refskill.Equals("")))
            {

                txtSelectALLinfo.Text += "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Reference :" + "\r\n" + refskill;
            }
            txtSelectALLinfo.Show();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSelectALLinfo.Clear();
            txtSearch.Clear();
            Login();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            DataTable db;
            bool search = bz.SelectOfSearchOf(txtSearch.Text.ToLower(), out db);
            if ((search) && (!(db.Rows.Equals(0))))
            {
                dgvemp.DataSource = db;
                txtSearch.Clear();
            }
            else
            {
                MessageBox.Show("0 item fund or you put numbre try again");     
            }
            
            
        }

        private void btnSumbitEmp_Click(object sender, EventArgs e)
        {
            bool emp = bz.InsertEmp(txtFn.Text, txtLn.Text, txtAlias.Text, txtEm.Text);
            if (emp)
            {
                txtLn.Clear();
                txtFn.Clear();
                txtAlias.Clear();
                txtEm.Clear();
                MessageBox.Show("add emp good");
            }
            else
            {
                MessageBox.Show("One of the parameters is invalid");

            }
            
           
            Login();
        }

        private void btnSumbitURL_Click(object sender, EventArgs e)
        {
            if (dgvskill.RowCount > 1)
            {

                int idSkill = Convert.ToInt32(dgvskill.CurrentRow.Cells[0].Value);

                bool bdurl = bz.InserUrl(txtURL.Text, idSkill);
                if (bdurl)
                {
                    MessageBox.Show("add https good");
                    txtURL.Clear();
                }
                else
                {
                    MessageBox.Show("One of the parameters is invalid");
                }
            }
            else
            {
                MessageBox.Show("Must have one skill for adding 'https' or ");
            }        
        }

        private void btnSumSkill_Click(object sender, EventArgs e)
        {
            int idemp=Convert.ToInt32(dgvemp.CurrentRow.Cells[0].Value.ToString());
            bool inserS = bz.InsertSkill(idemp, txtNameSkill.Text, txtberif.Text);
            if (inserS)
            {
                txtberif.Clear();
                txtNameSkill.Clear();
                MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("One of the parameters is invalid");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bz.Close();
            this.Close();

        }

        private void btnSumbitRef_Click(object sender, EventArgs e)
        {
            int empID=Convert.ToInt32(dgvemp.CurrentRow.Cells[0].Value);
            bool inser = bz.InserRef(txtLasRef.Text, txtFnRef.Text, txtPoRef.Text, txtAliRef.Text, txtEmRef.Text, empID);
            if (inser)
            {
                MessageBox.Show("add good ref");
                txtLasRef.Clear();
                txtFnRef.Clear();
                txtPoRef.Clear();
                txtAliRef.Clear();
                txtEmRef.Clear();
            }
            else
            {
                MessageBox.Show("One of the parameters is invalid");
            }
            Login();
          
        }


        private void dgvskill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linklblURL.Visible = false;
            string skillName = "";
            string brif = "";
            int id = Convert.ToInt32(dgvskill.CurrentRow.Cells[0].Value);
            string db;
            bool urlNullOrno = bz.SelURL(id, out db);
            linklblURL.Text = "";
            if (!(urlNullOrno))
            {
                linklblURL.Visible = true;
                linklblURL.Text = db;
            }

            if ((dgvskill.RowCount > 1))
            {

                skillName = dgvskill.CurrentRow.Cells[2].Value.ToString();
                brif = dgvskill.CurrentRow.Cells[3].Value.ToString();
                txtSelectALLinfo.Text = "Skill Name:  " + skillName + "\r\n" + "BriefDescription" + "\r\n" + brif;
            }



         
            txtSelectALLinfo.Show();

        }

        private void linklblURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Process.Start(linklblURL.Text);
        }

  

    }
}
