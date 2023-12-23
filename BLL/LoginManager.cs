using DAL;
using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Login.BLL
{
  
        public class LoginManager
        {
           

            public ActionResult Login(UserModel um)
            {
            Dbcontext db = new Dbcontext();
                var data = db.GetUser().Where(model => model.UserName == um.UserName && model.Password == um.Password).FirstOrDefault();
                if (data != null)
                {
                // Session["Username"] = um.UserName;
                return new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "AllUsers", action = "Users" }
                    )
                );
            }
                else
                {
                    // You can throw an exception or return a custom result in case of invalid login
                    return null;
                }
            }
        }
    }
