using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace WebMovies
{
    public class BeaniesLogic
    {

        private Dal date = Dal.Instance;

        #region Select whit join the all movies and catgory
        public IEnumerable<object> SelectMoviesBL()
        {
            return date.SelectMovies();
        }
        #endregion
        #region new movies
		 
            public void InsertBL(Movies newmovies)
            {
                date.InsertMovie(newmovies);
            }
	    #endregion
        #region Update Movie
        public void UpdateMovieBL(Movies updateMovies)
        {
            if (date.SelectOneMovie(updateMovies.MoviesID)!=null)
            {
                updateMovies.NameMovies.Trim();
                updateMovies.Description.Trim();
                if (updateMovies.ImageUrlOfMovies!=null)
                {
                    
                    updateMovies.ImageUrlOfMovies.Trim();
                }
                updateMovies.MovieDirector.Trim();
                updateMovies.Description.Trim();
                date.UpDate(updateMovies);
                
            }

        }
        #endregion 
        #region Search Name Mvovie whith ajax toolkit
        
        public  static List<string> SearchNameMoviesBL(string prefixText, int count)
        {
            prefixText.Trim();
            return  Dal.SearchNameMovies(prefixText, count);

        }
        #endregion
        #region select  all Category
        public List<Categoryes> SelectCategoryBL() 
        {
            return date.SelectCategory();
        }

        #endregion
        #region select the movies popular
        public List<Movies> TheBestMovieBL()
        {
            List<Movies> allMovies = date.AllMovies();
            if (allMovies.Count > 3)
            {
               return date.SelectMoviesBest();
            }
            return allMovies;
        }
        #endregion


        #region return true If the same user exists

        public bool IsexistsBL(string userName, string password)
        {
            if (date.SearchCustomer(userName, password) == null)
            {
                return false;
            }
            return true;


        }
        #endregion

        #region check if the customer is year after to create customer

        public bool CheckCustomer(string Email, string phone)
        {
            if (date.CheckCustomer(Email,phone)!=null)
            {
                return true;
            }
            return false;
        }



        #endregion
        #region register insert new Customer
        public void AddCustomerBL(Customer customer)
        {
            if (date.SearchCustomer(customer.UserName,customer.Pasword )==null)
            {
                date.AddCustomer(customer);
            }
           

        }
        #endregion
        #region remove movie
        public void RemoveBL(int id)
        {
            if (id>0)
            {
                 date.RemoveMovie(id);
                
            }
        }

        #endregion
        #region select One Movie whith name movie
        public Movies SelectOneMoviesBL(string nameMovies)
        {
            if (!nameMovies.Equals(null) && (nameMovies.Trim() != ""))
            {
                return date.SelectOneMovie(nameMovies);
            }
            return null;
        }
     

        #endregion

        #region select movie search whith id movie   
        public Movies SelectOneMoviesBL(int MoviesID)
        {
            if (MoviesID>0)
            {
               
                return date.SelectOneMovie(MoviesID);
            }
            return null;
        }



        #endregion


        #region select inventory in movie
        /// <summary>
        /// Returns the quantity in stock
        ///If you send quantity you will return in true or false out if you managed to download and some have wear and tear
        /// </summary>
        /// <param name="idmovies">ID of movies</param>
        /// <param name="isRmoveInInvntory">return false or true </param>
        /// <param name="amount"> amout to the coustomer whant to buy</param>
        /// <returns></returns>
        public int SearchInvntorBL(int idmovies, out bool isRmoveInInvntory, int amount = -1)
        {
            Movies moviesInvntory =date.SelectOneMovie(idmovies);
          
            if (amount != -1)
            {
                if (moviesInvntory != null)
                {
                    if (moviesInvntory.Inventory >= amount)
                    {

                        date.RemoveInvntory(amount, idmovies);

                        isRmoveInInvntory = true;
                        return moviesInvntory.Inventory - amount;
                    }
                    else
                    {
                        isRmoveInInvntory = false;
                        return moviesInvntory.Inventory;
                    }


                }
            }
            isRmoveInInvntory = false;
            return moviesInvntory.Inventory;
        }

        #endregion

        #region Add to rating 
        public void RatingAddBL(int rating, int iDmovies)
        {
            if ((rating>0)&&(rating<5))
            {
                date.RatingAdd(rating, iDmovies);
            }

        }
        #endregion

        #region this function return true if it manger

        public bool ItIsMangerBL(string userName, string password)
        {
            userName.Trim();
            password.Trim();
            if (date.ChecksItIsManger(userName,password)!=null)
            {
                return true;
                
            }
            return false;

        }
        #endregion

        #region If fille size and image
        public bool fillBL(FileUpload fill,out string erroe) 
        {
         
                    string fillExe = Path.GetExtension(fill.FileName);
                    if ((fillExe.ToLower().Equals(".jpg")) && (fill.PostedFile.ContentLength <= 2090000))
                    {
                        erroe = "";
                        return true;

                    }
                    else
                    {
                        
                        erroe = "erroe only picter .jpg and  must be size 2MB";
                        return false;
                    }
               
                

            
        }
        #endregion


        

    }
}