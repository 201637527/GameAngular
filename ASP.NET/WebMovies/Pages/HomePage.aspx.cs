using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;



namespace WebMovies
{
    public partial class HomePage : System.Web.UI.Page
    {
        private BeaniesLogic logic = new BeaniesLogic();
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                List<Movies> bestMovies = logic.TheBestMovieBL();
                LViewBestM.DataSource = bestMovies;
               
                
                Session["listMoviesBest"] = LViewBestM.DataSource;

                LViewBestM.DataBind();
            }
            else
            {
                LViewBestM.DataSource = (object)Session["listMoviesBest"];
                
                LViewBestM.DataBind();
              
            }
        }



        [ScriptMethod]
        [WebMethod]
        public static List<string> Search(string prefixText, int count)
        {
            List<string> search = BeaniesLogic.SearchNameMoviesBL(prefixText, count);
          
            return search;
        }

       

        protected void LViewBestM_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Rating rating = (Rating)e.Item.FindControl("RatingBestMO");
                List<Movies> bestMovies = logic.TheBestMovieBL();
                int IsZero = (bestMovies[e.Item.DataItemIndex].CuntRating);
                if (IsZero!=0)
                { 
                 rating.CurrentRating = ((bestMovies[e.Item.DataItemIndex].Rating) / (bestMovies[e.Item.DataItemIndex].CuntRating));
                }

                rating.DataBind();

            }
        }

        

        protected void btnSearch_Click(object sender, EventArgs e)
        {
           Movies one= logic.SelectOneMoviesBL(txtSearch.Text);
            if ((one!=null))
            {
                lblErroe.Text = "";
                Session["OneMoviesOfSearch"] = one;
                Response.Redirect("~/Pages/OneMovies.aspx");
            }
            else
            {
                
                lblErroe.Text = "erroe";
                lblErroe.ForeColor = Color.Red;
            }

        }

        protected void btnBuy_Command(object sender, CommandEventArgs e)
        {
            Movies one = logic.SelectOneMoviesBL(Convert.ToUInt16(e.CommandArgument.ToString()));
            Session["OneMoviesOfSearch"] = one;

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