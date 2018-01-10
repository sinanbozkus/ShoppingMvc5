using Shopping.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.DataAccess.Models;
using Shopping.DataAccess.Context;

namespace Shopping.WebUI.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUser(LoginViewModel formData)
        {
            ShoppingContext context = new ShoppingContext();

            User user =
                context.UserTable.Where(x => x.Username == formData.Username && x.Password == formData.Password).SingleOrDefault();

            if(user != null)
            {
                Session["User"] = user;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View("Index");
            }

            
        }
    }
}