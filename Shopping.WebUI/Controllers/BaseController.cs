using Shopping.DataAccess.Context;
using Shopping.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ShoppingContext context = new ShoppingContext();

            LayoutViewModel layoutVm = new LayoutViewModel();

            layoutVm.Categories
                = context.CategoryTable
                .Where(x => x.Active == true)
                .OrderBy(x => x.CategoryName)
                .ToList();

            ViewBag.Layout = layoutVm;

            base.OnActionExecuting(filterContext);
        }
    }
}