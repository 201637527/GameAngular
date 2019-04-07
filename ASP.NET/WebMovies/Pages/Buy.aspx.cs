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
    public partial class Buy : System.Web.UI.Page
    {
        private BeaniesLogic logic = new BeaniesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["OneMoviesOfSearch"]!=null)
            {
                 
                Movies OneMoviesAfterSearch = new Movies();
                OneMoviesAfterSearch = (Movies)Session["OneMoviesOfSearch"];
                lblMoviesName.Text = OneMoviesAfterSearch.NameMovies;
                lblMovieDirector.Text = OneMoviesAfterSearch.MovieDirector;
                lblDescription.Text = OneMoviesAfterSearch.Description;
                Image1.ImageUrl = OneMoviesAfterSearch.ImageUrlOfMovies;
             
               
                
            }
            else
            {
                if (Response.Cookies["userInfo"]!= null)
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {

                    Response.Redirect("Login.aspx");
                }
            }
            
            

        }

       

      

   

      

        protected void btnBuy_Command(object sender, CommandEventArgs e)
        {

      
            Movies oneaftersearch = (Movies)Session["OneMoviesOfSearch"];
            int amous;
            bool isNumberAmous = int.TryParse(txtCard.Text, out amous);
            if (isNumberAmous)
            {
                bool isRemoveInInventory;
                int invntory = logic.SearchInvntorBL(oneaftersearch.MoviesID, out isRemoveInInventory,Convert.ToInt16(txtCard.Text));

                if (isRemoveInInventory)
                {
                  
                        logic.RatingAddBL(Convert.ToInt16(RatingMovies.CurrentRating), oneaftersearch.MoviesID);
                 
                        Response.Redirect("PurchaseNot.aspx");
                }
                else
                {
                    if (invntory<=0)
                    {
                        lblwarning.ForeColor = Color.Red;

                        lblwarning.Text = "There are currently no items in stock";
                        
                    }
                    else
                    {
                        lblwarning.ForeColor = Color.Red;

                        lblwarning.Text = "Warning you can buy  only " + invntory;

                    }
                   

                }
            }

            lblwarning.Text = "Warning you can put only number 1-10";
         

            

        }

       

    }
}