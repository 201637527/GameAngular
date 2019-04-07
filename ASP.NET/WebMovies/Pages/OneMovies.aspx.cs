using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMovies.Pages
{
    public partial class OneMovies : System.Web.UI.Page
    {
        private BeaniesLogic logic = new BeaniesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OneMoviesOfSearch"] == null)
            {
                Response.Redirect("~/Pages/HomePage.aspx");
            }
            else
            {


                Movies oneMovies = (Movies)Session["OneMoviesOfSearch"];
                lblDescription.Text = oneMovies.Description;
                lblMovieDirector.Text = oneMovies.MovieDirector;
                Image1.ImageUrl = oneMovies.ImageUrlOfMovies;

                lblMoviesName.Text = oneMovies.NameMovies;
            }
            
            
         
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {

            if (Request.Cookies["userInfo"] == null)
            {
                Response.Redirect("~/Pages/Login.aspx");
            }
            else
            {
                Response.Redirect("~/Pages/Buy.aspx");

            }

        }
    }
}