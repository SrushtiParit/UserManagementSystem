using DAL;
using Login.DAL;
using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Controllers;

namespace Login.BLL
{
    public class UserManager
    {
        
        public List<Users> DisplayUsers()
        {
            DbUsers au = new DbUsers();
            return au.GetAllUsers();
        }

        public List<UserDetailsModel> UserDetail(string Username)
        {
            DbUsers ud = new DbUsers();
            return ud.GetUserDetails(Username);
        }

        public List<Users> SearchUser(string search, string sortBy, int Page, int PageSize)
        {
            DbUsers dbs = new DbUsers();
            return dbs.GetSearchResult(search, sortBy, Page, PageSize);
        }

        public void AddNewUser(string username, int Phone, string address, string mail)
        {
            DbUsers adduser = new DbUsers();
            adduser.AddUser(username, Phone, address, mail);
        }
    }
}