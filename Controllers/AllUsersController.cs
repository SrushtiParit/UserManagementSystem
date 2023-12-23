using Login.BLL;
using Login.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class AllUsersController : Controller
    {
        // GET: AllUsers
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Users()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Users(string search, string sortBy, int Page, int PageSize)
        {
            UserManager _userManager = new UserManager();
            List<Users> searchResult;
            searchResult = _userManager.SearchUser(search, sortBy, Page, PageSize);
            return Json(searchResult);
        }


        public ActionResult Details(string Username)
        {
            UserManager userdetails = new UserManager();
            var details = userdetails.UserDetail(Username);
            //ViewBag.Message = "step 1 successful";
            return View(details);
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
                UserManager adm = new UserManager();
                adm.AddNewUser(username, Phone, address, Email);
                return RedirectToAction("Users", "AllUsers");
            }
            else
            {
                // The model is not valid, return to the view with validation errors.
                return View();
            }
        }
    }
}
