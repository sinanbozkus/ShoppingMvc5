using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Areas.admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            //Session.Remove("User");
            return RedirectToAction("Index", "Login");
        }
    }
}