using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Areas.admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("/admin/login");
            }

            base.OnActionExecuting(filterContext);
        }
    }
}