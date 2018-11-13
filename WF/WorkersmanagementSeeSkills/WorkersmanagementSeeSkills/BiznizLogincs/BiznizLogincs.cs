using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkersmanagementSeeSkills.POCO;
namespace WorkersmanagementSeeSkills.BiznizLogincs
{
    class BiznizLogincs
    {
       
        public BiznizLogincs()
        {
            DAL.DataAccesslayer.Open();
        }
        #region SelRef
        public string SelRrf(int empId)
        {
            DataTable db = new DataTable();
            string refIdEmp =" ";
           
            db = DAL.DataAccesslayer.SelectRef(empId);
            
            for (int i =0; i < db.Rows.Count; i++)
            {
                for (int j = 1; j < db.Columns.Count-1; j++)
                {
                    refIdEmp += " ";
                    refIdEmp += string.Join(" ,  ", db.Rows[i].ItemArray.GetValue(j).ToString()).Trim();
                    
                }
                refIdEmp += "\r\n";
           
            }

            return refIdEmp;

        }
        #endregion
        #region SelectEMP
        
        public DataTable Selectemp() 
        {
            return DAL.DataAccesslayer.SelectEmploy();
        
        }
        #endregion
        #region Select skill
        
     
        public DataTable Selectskill()
        {
            return DAL.DataAccesslayer.SelectSkillsEmp();
        }
         #endregion
        #region select skill where empID
        
      
        public DataTable SeleIDemp(int idemp)  
        {
            return DAL.DataAccesslayer.SelectSkillsEmpwhereID(idemp);
        }
        #endregion
        #region SelecURL
        
      
        public bool SelURL( int idskill,out string urlsrt)
        {
            DataTable dat = new DataTable();
            dat = DAL.DataAccesslayer.SelectskillURL(idskill);
          
         
            if (dat.Rows.Count.Equals(0))
	        {
                urlsrt = "";
                return true;
		 
	        }
            urlsrt = dat.Rows[0][0].ToString();;
            return false; 
        
        }
        #endregion
        #region SeleSearch
       
        public bool SelectOfSearchOf(string txt,out DataTable db)
        {
            db = new DataTable();
           
           int n;
           bool isNumeric = int.TryParse(txt, out n);
            if (isNumeric)
	            {
                  return false;
	            }
            else
            {
                db = db = DAL.DataAccesslayer.SelectOfSearchOfEmployee(txt);
                return true;
             
            }
            
            
        }
         #endregion

        #region InserEmployee
        
       
        public bool InsertEmp(string firstName, string lastName, string alias, string email) 
        {

            bool isnull= IsnullOrEmpty(alias)||(IsnullOrEmpty(lastName)||(!email.ToLower().Contains("@")));
            if (isnull)
            {
                return false;
            }
            DAL.DataAccesslayer.InsertEmployees(firstName, lastName, alias, email);
            return true;
          
           
        
        }
        #endregion
        #region InserUrl
        
        
        public bool InserUrl(string texUrl, int idskill)
        {
            
            bool https = IsnullOrEmpty(texUrl);
          
         
            if (https)
            {
               
                return false;

            }
            else if (texUrl.ToLower().Contains("https")||(texUrl.ToLower().Contains("http")))
            {
               
                string url;
                if (SelURL(idskill,out url))
	                {
                        DAL.DataAccesslayer.InsertURL(texUrl, idskill);
                  
                        return true;
		 
	                }
               
            }
            return false;
           
               
     
       
        }
        #endregion
        #region InsertSkill
        
       

        public bool InsertSkill(int empID, string nameskill,string brief)
        {
            bool inserSkil=(IsnullOrEmpty(nameskill)||(IsnullOrEmpty(brief)));
            if (!(inserSkil))
	        {
                 DAL.DataAccesslayer.InsertSkill(empID,nameskill, brief);
		        return true; 
	        }
            return false;


           
        }
         #endregion
        #region IsnullOrEmpty
        
       
        public bool IsnullOrEmpty(string parm)
        {
            if ((parm.Equals(null))||(parm.Equals(""))||(parm.All(Char.IsNumber)))
	            {
                    return true;
	            }
            else
                {
                    return false;
                }

        }
        #endregion
        #region IsNum
        
       
        public bool IsNum(string parm)
        {
            if (parm.All(Char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }



       }

        #endregion
        #region InserRef

        public bool InserRef(string lastName,string firstName,string position,string alias,string email,int empID) 
        {

            if (IsnullOrEmpty(alias)|| IsnullOrEmpty(lastName)||(!(email.ToLower().Contains("@"))))
            {

                return false;
            }
            else
            {
                DAL.DataAccesslayer.InsertRef(lastName, firstName, position, alias, email, empID);
                return true;
            }
          
        }
          
        #endregion

        #region Close
        
       
        public void Close() 
        {
            DAL.DataAccesslayer.Close();

        }
        #endregion
    }
}
