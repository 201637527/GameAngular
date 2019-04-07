using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebMovies
{
    public class Global : System.Web.HttpApplication
    {
   #region Creat First Code 
		 
	
        protected void Application_Start(object sender, EventArgs e)
        {
            //try
            //{


            //    using (DbContextDrowDataBase dbcontex = new DbContextDrowDataBase())
            //    {
            //        Customer customerOne = new Customer
            //        {
            //            CardToBages = "458012346777",
            //            Email = "gdfgdfg@mail.com",
            //            NameCustomer = "Almog",
            //            LastName = "pop",
            //            Pasword = "5667",
            //            UserName = "dfgdfgd",
            //            Phone="0504123333"
            //        };
            //        Customer customer2 = new Customer
            //        {
            //            CardToBages = "45801234889",
            //            Email = "koko@mail.com",
            //            NameCustomer = "kobi",
            //            LastName = "opo",
            //            Pasword = "Aa2345",
            //            UserName = "hjlhh",
            //            Phone = "0504123393"
            //        }; Customer customer3 = new Customer
            //        {
            //            CardToBages = "458012300977",
            //            Email = "gilior@mail.com",
            //            NameCustomer = "gili",
            //            LastName = "1317",
            //            Pasword = "Ss556",
            //            UserName = "dfgdd",
            //            Phone = "0504128833"
            //        }; Customer customer4 = new Customer
            //        {
            //            CardToBages = "45801900777",
            //            Email = "Shmon@mail.com",
            //            NameCustomer = "Shimi",
            //            LastName = " 556",
            //            Pasword = "Xx4545",
            //            UserName = "dfguugd",
            //            Phone = "0504127633"
            //        }; Customer customer5 = new Customer
            //        {
            //            CardToBages = "458088806777",
            //            Email = "89Riki@mail.com",
            //            NameCustomer = "Riki",
            //            LastName = "1239094",
            //            Pasword = "Dd5656",
            //            UserName = "dfggd",
            //            Phone = "0504126783"

            //        };



            //        dbcontex.Customers.Add(customerOne);
            //        dbcontex.Customers.Add(customer2);
            //        dbcontex.Customers.Add(customer3);
            //        dbcontex.Customers.Add(customer4);
            //        dbcontex.Customers.Add(customer5);
            //        dbcontex.SaveChanges();
            //    }
            //}

            //catch (Exception exe)
            //{

            //    Response.Write(exe.Message);
            //}
        }
      

#endregion


    
    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown
    }
    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs
    }
    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started
    }
    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends.
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer
        // or SQLServer, the event is not raised.
    }
        
    }
}