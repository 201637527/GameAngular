using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMovies
{
    public class Dal
    {

        private DbContextDrowDataBase db;
        private static Dal data = Dal.Instance;

        #region SingelTon


        public static Dal Instance
        {
            get
            {
                if (data == null)
                {
                    return data = new Dal();
                }
                return data;
            }

        }
        #endregion



        #region check if the customer is year after to create customer

        public Customer CheckCustomer(string email, string phone)
        {
            Customer checkCustomer;
            using (db = new DbContextDrowDataBase())
            {
                checkCustomer= db.Customers.FirstOrDefault(m=>m.Email.Equals(email)&&(m.Phone.Equals(phone)));
              
            }
            return checkCustomer;
        }


        #endregion



        #region select movies  whith join the catgory

        public IEnumerable<object> SelectMovies()
        {
            using (db = new DbContextDrowDataBase())
            {

                var dbAllMovies =
                  (from e in db.Movies
                   join p in db.Categoryes

                   on e.CategoryID equals p.CategoryID
                   select new
                   {
                       e.NameMovies,
                       e.MoviesID,
                       e.ImageUrlOfMovies,
                       e.Inventory,
                       e.MovieDirector,
                       e.Rating,
                       e.Description,
                       e.CuntRating,

                       discription = p.Description,

                   }).ToList();

                return dbAllMovies;

            }
        }
        #endregion
        #region Add new movie
        
      
        public void InsertMovie(Movies newMovies)
        {
            using (db = new DbContextDrowDataBase())
            {
                db.Movies.Add(newMovies);
                db.SaveChanges();
            }

        }

        #endregion
        #region update movie
        
        public void UpDate(Movies UpDataMo)
        {
            using (db = new DbContextDrowDataBase())
            {
                Movies movies = db.Movies.FirstOrDefault(m => m.MoviesID == UpDataMo.MoviesID);
                    movies.NameMovies = UpDataMo.NameMovies;
                    movies.Inventory = UpDataMo.Inventory;
                    movies.Description = UpDataMo.Description;
                    movies.MovieDirector = UpDataMo.MovieDirector;
                    movies.CategoryID = UpDataMo.CategoryID;
                    if (UpDataMo.ImageUrlOfMovies!=null)
                    {
                        
                        movies.ImageUrlOfMovies = UpDataMo.ImageUrlOfMovies;
                    }
                    db.Entry(movies).State = EntityState.Modified;
                    db.SaveChanges();

            }


        }

        #endregion


        #region search movie Ajax toolkit
        
      
        public static List<string> SearchNameMovies(string prefixText, int count)
        {
            using (DbContextDrowDataBase db = new DbContextDrowDataBase())
            {

                List<string> matches = (from m in db.Movies
                                        where m.NameMovies.StartsWith(prefixText)
                                        select m.NameMovies).ToList();
                return matches;
            }
        }
        #endregion



        #region Select all catgory
        
        
        public List<Categoryes> SelectCategory()
        {
            using (db = new DbContextDrowDataBase())
            {

                return db.Categoryes.ToList();

            }
        }
        #endregion

        #region select all movies
       
        public List<Movies> AllMovies()
        {
            using (db = new DbContextDrowDataBase())
            {
                return db.Movies.ToList();
            }
        }
        #endregion




        #region Select the movies best 
        
     
        public List<Movies> SelectMoviesBest()
        {
            using (db = new DbContextDrowDataBase())
            {
               
                    db = new DbContextDrowDataBase();
                    List<Movies>  best = db.Movies.OrderByDescending(m => m.Rating).Take(3).ToList();
                    return best;
                
            }
        }
        #endregion

        #region SearchCustomer
        
        
        public Customer SearchCustomer(string userName, string password)
        {
            using (db = new DbContextDrowDataBase())
            {

                Customer customer = db.Customers.FirstOrDefault(m => m.UserName.Equals(userName) && (m.Pasword.Equals(password)));
                return customer;
            }

        }
        #endregion

        #region AddCustomer
        
      
        public void AddCustomer(Customer creatNewCustomer)
        {
            using (db = new DbContextDrowDataBase())
            {
                db.Customers.Add(creatNewCustomer);
                db.SaveChanges();
            }

        }

        #endregion


        #region RemoveMovie
        
       

        public void RemoveMovie(int id)
        {
            using (db = new DbContextDrowDataBase())
            {
                Movies movies = db.Movies.FirstOrDefault(m => m.MoviesID == id);
                if (movies!= null)
                {
                    db.Movies.Remove(movies);

                    db.SaveChanges();

                }
            }
        }
        #endregion
        #region SelectOneMovie

        
        public Movies SelectOneMovie(string nameMovies)
        {
            Movies SearchOne;

                using (db = new DbContextDrowDataBase())
                {
                    SearchOne = (db.Movies.FirstOrDefault(m => m.NameMovies == nameMovies));
                }
           
            return SearchOne;
        }

        #endregion


        #region SelectOneMovie
      
        public Movies SelectOneMovie(int MoviesID)
        {
            Movies SearchOne = new Movies();

            if (MoviesID >= 0)
            {

                using (db = new DbContextDrowDataBase())
                {
                    SearchOne = (db.Movies.FirstOrDefault(m => m.MoviesID == MoviesID));
                }
            }
            return SearchOne;
        }

          
        #endregion

        #region RemoveInvntory
        
        

        public void RemoveInvntory(int amout,int idMovie)
        {
            using (db = new DbContextDrowDataBase())
            {
                Movies removeInvntory = db.Movies.FirstOrDefault(m => m.MoviesID.Equals(idMovie));
                removeInvntory.Inventory-=amout;
            }


        }
        #endregion

        #region RatingAdd
        
        

        public void RatingAdd(int rating, int iDmovies)
        {
            using (db = new DbContextDrowDataBase())
            {
                Movies addRatintToMovies = db.Movies.FirstOrDefault(x => x.MoviesID.Equals(iDmovies));
                addRatintToMovies.Rating = addRatintToMovies.Rating + rating;
                addRatintToMovies.CuntRating += 1;
                db.Entry(addRatintToMovies).State = EntityState.Modified;
                db.SaveChanges();

            }
        }
        #endregion



        #region Checks whether this is a manager
        
        public Manger ChecksItIsManger(string userName, string password)
        {
            Manger checkerItIs;
            using (db = new DbContextDrowDataBase())
            {
                checkerItIs = db.Manger.FirstOrDefault(m => m.UserName.Equals(userName) && (m.Password.Equals(password)));

            }
          
            return checkerItIs;
        }



        #endregion
    }
}