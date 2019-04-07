using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.Script.Services;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace WebMovies
{
    public partial class ListMovies : System.Web.UI.Page
    {

        BeaniesLogic logic = new BeaniesLogic();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
            {


            listVAllMovies.DataSource = logic.SelectMoviesBL();
            Session["listVAllMovies"] = listVAllMovies.DataSource;
            listVAllMovies.DataBind();


            }
            else
            {
                listVAllMovies.DataSource = (object)Session["listVAllMovies"];
                listVAllMovies.DataBind();
            }
            
    
            
        }



        [ScriptMethod]
        [WebMethod]

       
        public static List<string> Search(string prefixText, int count)
        {

            List<string> search = BeaniesLogic.SearchNameMoviesBL(prefixText, count);
         
            return search;
        }

        
        protected void btnSearch_Click(object sender, EventArgs e)
        {


            Movies one = logic.SelectOneMoviesBL(txtSearch.Text);
            if ( (one != null))
            {
                lblErroe.Text = "";
                Session["OneMoviesOfSearch"] = one;
                Response.Redirect("~/Pages/OneMovies.aspx");
            }
            else
            {
                
                lblErroe.Text = "erroe The name movis undfind";
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