using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMovies
{
    public partial class Login : System.Web.UI.Page
    {
        private BeaniesLogic logic = new BeaniesLogic();
       
        protected void btnLgin_Click(object sender, EventArgs e)
        {
            HttpCookie mCookie;

            if (IsValid)
            {
               bool isExisets= logic.IsexistsBL(txtUsername.Text, txtPASS.Text);

               if ((CheckBoxRemmeber.Checked) && (isExisets))
                {

                    mCookie = new HttpCookie("userInfo");
                    mCookie["userName"] = txtUsername.Text;
                    mCookie["Pass"] = txtPASS.Text;
                    mCookie.Expires = DateTime.Now.AddHours(6);
                    Response.Cookies.Add(mCookie);
                    Response.Redirect("Buy.aspx");
                        


                }
                else
                {
                    if (isExisets)
	                {
                        Response.Redirect("Buy.aspx");
		 
	                }
                    

              
                    else
                    {
                        txtUsername.Text = "";
                        linkToRegister.Text = "The name does not exist in the system yom must Register";
                        linkToRegister.ForeColor = Color.Red;
                        linkToRegister.BackColor = Color.Yellow;
                    }


                }

               

            }

        }
       

      
    }
}