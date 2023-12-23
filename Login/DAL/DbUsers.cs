using Login.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Login.DAL
{
    public class DbUsers
    {
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        public SqlConnection con = new SqlConnection(cs);

        public void AddUser(string username, int phone, string address, string email)
        {
            string query = "spInsertUser @Username, @Phone, @Address, @Email";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                con.Open();
                int num = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Users> GetSearchResult(string search, string sortBy, int Page, int PageSize)
        {
            List<Users> lst = new List<Users>();
            SqlCommand cmd = new SqlCommand("spGetUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Search", search);
            cmd.Parameters.AddWithValue("@SortExpression", sortBy);
            cmd.Parameters.AddWithValue("@Page", Page);
            cmd.Parameters.AddWithValue("@PageSize", PageSize);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new Users
                {
                    RowNum = Convert.ToInt16(dr[0]),
                    Username = Convert.ToString(dr[1]),
                    Phone = Convert.ToString(dr[2]),
                    Address = Convert.ToString(dr[3]),
                    Email = Convert.ToString(dr[4])
                });
            }
            return lst;
        }
    }
}