using Shopping.DataAccess.Context;
using Shopping.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            ShoppingContext context = new ShoppingContext();

            HomeViewModel homeVm = new HomeViewModel();

            homeVm.CarouselProducts
                = context.ProductTable
                .Where(x => x.Active == true && (x.ImageUrl != null && x.ImageUrl != ""))
                .OrderByDescending(x => x.Id)
                .Take(5)
                .ToList();

            homeVm.Products
                = context.ProductTable
                .Include(x => x.Category)
                .Where(x => x.Active)
                .OrderByDescending(x => x.Id)
                .Take(12)
                .ToList();


            return View(homeVm);
        }
    }
}