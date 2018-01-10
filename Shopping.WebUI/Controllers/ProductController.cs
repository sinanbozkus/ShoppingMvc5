using Shopping.DataAccess.Context;
using Shopping.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Product
        public ActionResult Index(int id)
        {
            ShoppingContext context = new ShoppingContext();

            Product product = context.ProductTable
                .Where(x => x.Active && x.Id == id)
                .SingleOrDefault();

            return View(product);
        }
    }
}