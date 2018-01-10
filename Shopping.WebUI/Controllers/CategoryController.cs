using Shopping.DataAccess.Context;
using Shopping.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Category
        public ActionResult Index(int id)
        {
            ShoppingContext context = new ShoppingContext();

            List<Product> productList = context.ProductTable
                                        .Include(x => x.Category)
                                        .Where(x => x.Active && x.CategoryId == id)
                                        .OrderByDescending(x => x.Id)
                                        .ToList();

            return View(productList);
        }

        public ActionResult Search(string searchedText)
        {
            ShoppingContext context = new ShoppingContext();

            List<Product> productList = context.ProductTable
                .Include(x => x.Category)
                .Where(x => x.Active &&
                (x.ProductName.Contains(searchedText) || x.Description.Contains(searchedText) || 
                x.Category.CategoryName.Contains(searchedText)))
                .OrderBy(x => x.ProductName)
                .ToList();

            return View("Index", productList);
        }
    }
}