using Login.BLL;
using Login.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class AllUsersController : Controller
    {
        private UserManager _userManager;
        public AllUsersController()
        {
            _userManager = new UserManager();
        }
        [HttpGet]
        public ActionResult Users()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Users(string search, string sortBy, int Page, int PageSize)
        {
            List<Users> searchResult;
            searchResult = _userManager.SearchUser(search, sortBy, Page, PageSize);
            return Json(searchResult);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string username, int Phone, string address, string Email)
        {  
            if (ModelState.IsValid)
            {
                _userManager.AddNewUser(username, Phone, address, Email);
                return RedirectToAction("Users", "AllUsers");
            }
            else
            {
                return View();
            }
        }
    }
}
