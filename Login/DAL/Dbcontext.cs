using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;       //this we are going to import to to give instruction to browser through web.config file 
using Login.Models;

namespace DAL
{
    public class Dbcontext
    {
       static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        public SqlConnection con = new SqlConnection(cs);

         public List<UserModel> GetUser()
        {
            List<UserModel> lst = new List<UserModel>();
            SqlCommand cmd = new SqlCommand("select * from tblLogin", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new UserModel
                {
                    UserName = Convert.ToString(dr[0]),
                    Password = Convert.ToString(dr[1])
                });
            }
            return lst;
        }
       
    }
}