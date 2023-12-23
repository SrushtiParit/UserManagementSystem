using Login.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Login.BLL;
///using MvcUserPanel.Models;

namespace Login.Controllers
{
    public class UserPanelController : Controller
    {
        private LoginManager loginManager;
        public UserPanelController()
        {
            loginManager = new LoginManager();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel um)
        {
            var result = loginManager.Login(um);

            if (result != null)
            {
                return result;
            }
            else
            {
                ViewBag.Showmsg = "Invalid Username or password";
                ModelState.Clear();
                return View();
            }
        }
        public ActionResult welcome()
        {
            return View();
        }
    }
}