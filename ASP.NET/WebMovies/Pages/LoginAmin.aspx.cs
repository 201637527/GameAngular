using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMovies.Pages
{
    public partial class LoginAmin : System.Web.UI.Page
    {
        private BeaniesLogic logic = new BeaniesLogic();
       

 
        protected void btnLgin_Click(object sender, EventArgs e)
        {


            if (logic.ItIsMangerBL(txtUsername.Text, txtPASS.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
                Response.Redirect("MangerEdit.aspx");

            }
            else
            {
                lblMassage.Text = "Invalid credentials. Please try again.";
            }

        }

       
    }
}