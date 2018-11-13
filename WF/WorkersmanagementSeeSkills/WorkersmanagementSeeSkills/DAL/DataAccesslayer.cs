using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkersmanagementSeeSkills.POCO;

namespace WorkersmanagementSeeSkills.DAL
{
   
        // like singlton
   public class DataAccesslayer
   {

       #region Datamember

       private static string con = ConfigurationManager.ConnectionStrings["SkillEmp"].ConnectionString;
       private static SqlConnection sqlCon  = new SqlConnection(con);
       private static DataAccesslayer dal;

      #endregion
       #region like singlton

       public static DataAccesslayer Datamanger()
       {
           if (dal==null)
           {
               return dal = new DataAccesslayer();
           }
           else
           {
               return dal;
           }
       }
       #endregion

       #region Open
       public static void Open()
       {
           try
           {
         
               sqlCon.Open();

           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);

           }


       }
      
	#endregion
       #region Close
       public static void Close()
       {
           try
           {

               
               sqlCon.Close();

           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);

           }

       }
       #endregion

       #region Employ
        public static DataTable SelectEmploy()
        {
            string query = String.Format("SELECT EmployeeId, LastName, FirstName, Alias, Email FROM  Employees ");
            SqlCommand com = new SqlCommand();
            com.CommandText = query;
            DataTable da = new DataTable();
            com.Connection = sqlCon;
            SqlDataReader re = com.ExecuteReader();
            da.Load(re);

            com.Dispose();


            return da;

           
        }
        #endregion
       #region SelectSkillsEmp where id employees

        public static DataTable SelectSkillsEmpwhereID(int  employID)
        {
            string qery = string.Format("SELECT  SkillID, EmployeeId, SkilName, BriefDescription FROM Skills where EmployeeId= @EmployeeId");
            SqlCommand com = new SqlCommand();
            SqlParameter parm = new SqlParameter();
            parm.ParameterName = "@EmployeeId";
            parm.SqlDbType = SqlDbType.Int;
            parm.Value = employID;
            com.Parameters.Add(parm);
            com.CommandText = qery;
            com.Connection = sqlCon;
            DataTable da = new DataTable();
            SqlDataReader re = com.ExecuteReader();
            da.Load(re);        
            com.Dispose();
            return da;
           

        }
        #endregion
       #region SelectSkillsEmp

        public static DataTable SelectSkillsEmp()
        {
            string qery = string.Format("SELECT  SkillId, EmployeeId, SkilName, BriefDescription FROM Skills");
            SqlCommand com = new SqlCommand();
            com.CommandText = qery;
            DataTable da = new DataTable();
            com.Connection = sqlCon;
            SqlDataReader re = com.ExecuteReader();
            da.Load(re);
            com.Dispose();
            return da;

          

        }
        #endregion
       #region Select Search of employees

        public static DataTable SelectOfSearchOfEmployee(string search)
        {
            string query = String.Format("SELECT  Employees.EmployeeId,LastName, FirstName,Alias, Email FROM Employees INNER JOIN Skills ON Employees.EmployeeId = Skills.EmployeeId WHERE (SkilName = @SkilName)");

            SqlParameter par = new SqlParameter();
            SqlCommand com = new SqlCommand();

            par.ParameterName = "@SkilName";
            par.SqlDbType = SqlDbType.NVarChar;
            par.Value = search;
            par.Size = 250;
            com.Parameters.Add(par);
            com.CommandText = query;
            DataTable da = new DataTable();
            com.Connection = sqlCon;
            SqlDataReader re = com.ExecuteReader();
            da.Load(re);
            com.Dispose();
            return da;
            
        }

        #endregion
       #region SelectSkillsEmp where id skill

        public DataTable SelectSkillsEmpwhereIDskill(int Idskill)
        {
            string qery = string.Format("SELECT  SkillID, EmployeeId, SkilName, BriefDescription FROM Skills where (SkillID =@SkillID)");
            SqlCommand com = new SqlCommand();
            SqlParameter parm = new SqlParameter();
            parm.ParameterName = "@SkillID";
            parm.SqlDbType = SqlDbType.Int;
            parm.Value = Idskill;
            com.Parameters.Add(parm);
            com.CommandText = qery;
            DataTable da = new DataTable();
            com.Connection = sqlCon;
            SqlDataReader re = com.ExecuteReader();
            da.Load(re);
            com.Dispose();
            return da;
            

        }
        #endregion
       #region SelectURL
        public static DataTable SelectskillURL(int SkillsInfoid)
        {
            string qery = string.Format("SELECT  URL FROM SkillIdInfoes WHERE (SkillID =@SkillID)");
            SqlCommand com = new SqlCommand();
            SqlParameter par = new SqlParameter();
            par.Value = SkillsInfoid;
            par.ParameterName = "@SkillID";
            par.SqlDbType = SqlDbType.Int;
            com.Parameters.Add(par);
            com.CommandText = qery;
            DataTable da = new DataTable();
            com.Connection = sqlCon;
            SqlDataReader re = com.ExecuteReader();
            da.Load(re);
            com.Dispose();
            return da;

        }
        #endregion
       #region Select referenc
        public static DataTable SelectRef(int employID)
        {
            string qery = string.Format("SELECT  * FROM Refs where EmployeeId=@EmployeeId");
            SqlCommand com = new SqlCommand();
            SqlParameter parm = new SqlParameter();
            parm.ParameterName = "@EmployeeId";
            parm.SqlDbType = SqlDbType.Int;

           
            parm.Value = employID;
            com.Parameters.Add(parm);
            com.CommandText = qery;
            DataTable da = new DataTable();
            com.Connection = sqlCon;
            SqlDataReader re = com.ExecuteReader();
            da.Load(re);
            com.Dispose();
            return da;

        }
        #endregion

       #region InsertURL

        public  static void InsertURL(string skiInfo, int SkilID )
        {
            string qery = string.Format("INSERT INTO SkillIdInfoes(URL, SkillId)VALUES (@URL,@SkillId)");
            SqlCommand com = new SqlCommand();

            SqlParameter par = new SqlParameter();
            par.ParameterName = "@URL";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 250;
            par.Value = skiInfo;
            com.Parameters.Add(par);
            par = new SqlParameter();

            par.ParameterName = "@SkillId";
            par.SqlDbType = SqlDbType.Int;

            par.Value = SkilID;
            com.Parameters.Add(par);
            com.CommandText = qery;
            com.Connection = sqlCon;
            com.ExecuteNonQuery();
            com.Dispose();




        }
        #endregion
       #region Inserskill

        public static void InsertSkill(int empid ,string skillName,string brifDescription  )
        {
            string qery = string.Format("INSERT INTO Skills(EmployeeId,SkilName, BriefDescription)VALUES (@EmployeeId,@SkilName,@BriefDescription)");
            SqlCommand com = new SqlCommand();
            SqlParameter par = new SqlParameter();


            par.ParameterName = "@EmployeeId";
            par.SqlDbType = SqlDbType.Int;
            par.Value = empid;
            com.Parameters.Add(par);
            par = new SqlParameter();
            par.ParameterName = "@SkilName";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = skillName;
            com.Parameters.Add(par);
            par = new SqlParameter();
            par.ParameterName = "@BriefDescription";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = brifDescription;
            com.Parameters.Add(par);
            com.CommandText = qery;
            com.Connection = sqlCon;
            com.ExecuteNonQuery();
            com.Dispose();
            




        }
        #endregion
       #region InsertEmployees

        public static void InsertEmployees(string firstName, string lastName, string alias, string email)
        {
            string qery = string.Format("INSERT INTO Employees(LastName, FirstName, Alias, Email)VALUES (@LastName,@FirstName,@Alias,@Email) ");
            SqlCommand com = new SqlCommand();

            SqlParameter par = new SqlParameter();
            par.ParameterName = "@LastName";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = lastName;
            com.Parameters.Add(par);
            par = new SqlParameter();
            par.ParameterName = "@FirstName";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = firstName;
            com.Parameters.Add(par);
            par = new SqlParameter();
            par.ParameterName = "@Alias";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = alias;
            com.Parameters.Add(par);
            par = new SqlParameter();
            par.ParameterName = "@Email";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = email;
            com.Parameters.Add(par);
            com.CommandText = qery;
            com.Connection = sqlCon;
            com.ExecuteNonQuery();
            com.Dispose();





        }
        #endregion
       #region InsertRef

        public static void InsertRef(string lastName, string firstName, string position, string alias, string email, int empID)
        {
            string qery = string.Format("INSERT INTO Refs(LastName,FirstName, Psition, Alias, Email, EmployeeId)VALUES (@LastName,@FirstName,@Psition,@Alias,@Email,@EmployeeId)");
            SqlCommand com = new SqlCommand();

            SqlParameter par = new SqlParameter();
            par.ParameterName = "@LastName";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = lastName;
            com.Parameters.Add(par);

            par = new SqlParameter();
            par.ParameterName = "@FirstName";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = firstName;
            com.Parameters.Add(par);


            par = new SqlParameter();
            par.ParameterName = "@Psition";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = position;
            com.Parameters.Add(par);

            par = new SqlParameter();
            par.ParameterName = "@Alias";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = alias;
            com.Parameters.Add(par);

            par = new SqlParameter();
            par.ParameterName = "@Email";
            par.SqlDbType = SqlDbType.NChar;
            par.Size = 50;
            par.Value = email;
            com.Parameters.Add(par);

            par = new SqlParameter();
            par.ParameterName = "@EmployeeId";
          
            par.SqlDbType = SqlDbType.Int;
            par.Value = empID;
            com.Parameters.Add(par);
            com.CommandText = qery;
            com.Connection = sqlCon;
            com.ExecuteNonQuery();
            com.Dispose();







        }
        #endregion
      
    }
}



  
