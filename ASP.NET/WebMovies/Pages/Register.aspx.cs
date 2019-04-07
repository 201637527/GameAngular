using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMovies
{
    public partial class Register : System.Web.UI.Page
    {
        private BeaniesLogic logic = new BeaniesLogic();
       
        protected void btnSingOut_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogOn_Click(object sender, EventArgs e)
        {
            
         
          string phone=DropPhone.Text + "-" + txtPone.Text;
          if ((!logic.IsexistsBL(txtUser.Text, txtPass.Text))&&(!logic.CheckCustomer(txtEmail.Text,phone)))
            { 
               
                HttpCookie mCookie;

                if (CheckBox1.Checked)
                {

                    mCookie = new HttpCookie("userInfo");
                    mCookie["userName"] = txtUser.Text;
                    mCookie["Pass"] = txtPass.Text;
                    mCookie.Expires = DateTime.Now.AddHours(6);
                    Response.Cookies.Add(mCookie);
                    RegisterInData();
                    Response.Redirect("~/Pages/Buy.aspx");
                }
                else
                {
                    RegisterInData();
                    Response.Redirect("~/Pages/Buy.aspx");
                }

               
            }
            else
            {
                lblMaseg.Text = " the name or password has already been reached, please click again";
                lblMaseg.ForeColor = Color.Red;
                
            }
        }
    
        
        private void RegisterInData()
        {

            Customer creat = new Customer();
            creat.NameCustomer = txtNameFirst.Text;
            creat.Email = txtEmail.Text;
            creat.Pasword = txtPass.Text;
            creat.UserName = txtUser.Text;
            creat.LastName=txtLastName.Text;
            creat.CardToBages = txtCardToBuy.Text;
            creat.Phone = DropPhone.Text + "" + txtPone.Text;
            logic.AddCustomerBL(creat);

        }
    }
}