using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMovies.Pages
{
    public partial class PurchaseNot : System.Web.UI.Page
    {
       
        protected void btnSingOut_Click(object sender, EventArgs e)
        {

            if (Response.Cookies["userInfo"] != null)
            {
                Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(-1);
                Session["OneMoviesOfSearch"] = null;

            }

            Response.Redirect("HomePage.aspx");

          
        }
    }
}