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
        private DbUsers _dbUsers;
        public UserManager()
        {
            _dbUsers = new DbUsers();
        }

        public List<Users> SearchUser(string search, string sortBy, int Page, int PageSize)
        {
            return _dbUsers.GetSearchResult(search, sortBy, Page, PageSize);
        }

        public void AddNewUser(string username, int Phone, string address, string mail)
        {
            _dbUsers.AddUser(username, Phone, address, mail);
        }
    }
}