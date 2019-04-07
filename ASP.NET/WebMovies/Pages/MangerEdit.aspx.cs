using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMovies
{

    public partial class MangerEdit : System.Web.UI.Page
    {
        private BeaniesLogic logic = new BeaniesLogic();


        private void BindData()
        {


            gvAdmin.DataSource = logic.SelectMoviesBL();
            Session["allMovies"] = gvAdmin.DataSource;
            gvAdmin.DataBind();


        }



        protected void Page_Load(object sender, EventArgs e)
        {
           
                List<Categoryes> dt = logic.SelectCategoryBL();

                ListItem item;

                for (int j = 0; j < dt.Count; j++)
                {
                    item = new ListItem();
                    item.Value = dt[j].CategoryID.ToString();
                    item.Text = dt[j].Description.ToString();

                    DropCategryInsert.Items.Add(item);
                }

                BindData();

                Session["Catgory"] = dt;
                gvAdmin.DataBind();
      
        }



        protected void gvAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {

            gvAdmin.EditIndex = e.NewEditIndex;


          BindData();

        }

        protected void gvAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvAdmin.EditIndex = -1;

            BindData();
        }

       


        protected void gvAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            BindData();
       
            int idMovieRmove =Convert.ToInt16(gvAdmin.DataKeys[e.RowIndex].Value);
            logic.RemoveBL(idMovieRmove);
          
             BindData();
          
        }

    







        protected void gvAdmin_RowDataBound(object sender, GridViewRowEventArgs e)
        {


            if ((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                DropDownList drpcategory1 = (DropDownList)e.Row.FindControl("DropCategry");

                List<Categoryes> db = (List<Categoryes>)Session["Catgory"];
                ListItem item;
                for (int j = 0; j < db.Count; j++)
                {
                    item = new ListItem();
                    item.Value = db[j].CategoryID.ToString();
                    item.Text = db[j].Description.ToString();

                     drpcategory1.Items.Add(item);
                }
           
            }
          
          
        }

     





        protected void gvAdmin_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
           

                FileUpload fill = (FileUpload)gvAdmin.Rows[e.RowIndex].Cells[0].FindControl("FileUpload1");
                Label lblErroe = (Label)gvAdmin.Rows[e.RowIndex].Cells[0].FindControl("lblErroe");
                lblErroe.Text = "";
                string erroe;
                 Movies upData = new Movies();
                 upData.MoviesID = Convert.ToInt16(((Label)gvAdmin.Rows[e.RowIndex].Cells[0].FindControl("lblMoviesID")).Text);
                 upData.NameMovies = ((TextBox)gvAdmin.Rows[e.RowIndex].Cells[1].FindControl("txtNameMoviesEdit")).Text;
                 upData.MovieDirector = ((TextBox)gvAdmin.Rows[e.RowIndex].Cells[3].FindControl("txtMovieDirector")).Text;
                 upData.Inventory = (Convert.ToInt16(((TextBox)gvAdmin.Rows[e.RowIndex].Cells[5].FindControl("txtInventory")).Text));
                 upData.Description = ((TextBox)gvAdmin.Rows[e.RowIndex].Cells[4].FindControl("txtDescription")).Text;
                 string cagoryId = ((DropDownList)gvAdmin.Rows[e.RowIndex].Cells[4].FindControl("DropCategry")).SelectedValue;
                 upData.CategoryID = Convert.ToInt16(cagoryId);


                if (fill.HasFile)
                {
                    if (!logic.fillBL(fill, out erroe))
                    {
                        fill.Attributes.Clear();
                        lblErroe.Text = erroe;
                    
                    }
                    else
                    {
                        fill.SaveAs(Server.MapPath("../Image/" + fill.FileName));
                        upData.ImageUrlOfMovies = "../Image/" + fill.FileName;
                        
                        logic.UpdateMovieBL(upData);
                        gvAdmin.EditIndex = -1;

                        BindData();
                    }
                }
                else
                {


                    
                    logic.UpdateMovieBL(upData);

                    gvAdmin.EditIndex = -1;

                    BindData();

                }

           



        }

        
        protected void btnSingOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("HomePage.aspx");

        }

       

        private void ClearText()
        {
            FileUploadIsert.Attributes.Clear();
            txtNameMoviesIsert.Text = "";
            txtInventoryInsert.Text = "";
            txtMovieDirectorIsert.Text = "";
            lblerroe5.Text = "";
            txtDescriptionIsert.Text = "";
            lblerroe2.Text = "";

        }

        protected void linkInsert_Click1(object sender, EventArgs e)
        {

            string erroe;
            if (FileUploadIsert.HasFile)
            {
                if (logic.fillBL(FileUploadIsert, out erroe))
                {
                    Movies creatNewMovies = new Movies();
                    FileUploadIsert.SaveAs(Server.MapPath("../Image/" + FileUploadIsert.FileName));
                    creatNewMovies.ImageUrlOfMovies = "../Image/" + FileUploadIsert.FileName;
                    creatNewMovies.NameMovies = txtNameMoviesIsert.Text;
                    creatNewMovies.MovieDirector = txtMovieDirectorIsert.Text;
                    creatNewMovies.Description = txtDescriptionIsert.Text;
                    creatNewMovies.Inventory = Convert.ToInt16(txtInventoryInsert.Text);
                    string dropValue = DropCategryInsert.SelectedValue;
                    int catgory = Convert.ToInt16(dropValue);
                    creatNewMovies.CategoryID = catgory;
                    logic.InsertBL(creatNewMovies);
                    ClearText();
                    BindData();
                }
                else
                {
                    FileUploadIsert.Attributes.Clear();
                    lblerroe2.Text = erroe;
                    lblerroe2.ForeColor = Color.Red;
                  


                }
            }
            else
            {

                FileUploadIsert.Attributes.Clear();
                lblerroe2.Text = "Erroe The Image File Cant Be Eempty";
                lblerroe2.ForeColor = Color.Red;
               
            }
        }

      
       
      
    }
    
}
