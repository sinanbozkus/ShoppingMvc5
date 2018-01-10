using Shopping.DataAccess.Context;
using Shopping.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Areas.admin.Controllers
{
    public class ProductController : BaseController
    {
        // GET: admin/Product
        public ActionResult Index()
        {
            ShoppingContext context = new ShoppingContext();

            List<Product> productList
                = context.ProductTable.Include(x => x.Category)
                .OrderBy(x => x.ProductName)
                .ToList();


            return View(productList);
        }

        private void CreateLookups()
        {
            ShoppingContext context = new ShoppingContext();

            List<Category> categories
                = context.CategoryTable.OrderBy(x => x.CategoryName).ToList();

            SelectList categoriesSelectList = new SelectList(categories, "Id", "CategoryName");

            ViewBag.Categories = categoriesSelectList;
        }

        public ActionResult Add()
        {
            CreateLookups();

            return View("Form");
        }

        public ActionResult Edit(int id)
        {
            CreateLookups();

            ShoppingContext context = new ShoppingContext();

            Product product = context.ProductTable.Where(x => x.Id == id).SingleOrDefault();

            return View("Form", product);

        }

        public ActionResult Save(Product formData, HttpPostedFileBase fileImage)
        {
            ShoppingContext context = new ShoppingContext();

            if(formData.Id == 0)
            { // insert

                if(fileImage != null)
                {
                    string filePath = Server.MapPath("~/Contents/Images/" + fileImage.FileName);
                    fileImage.SaveAs(filePath);

                    formData.ImageUrl = fileImage.FileName;
                }
              
                context.ProductTable.Add(formData);
                context.SaveChanges();

            }
            else
            { // update

                Product product
                    = context.ProductTable.Where(x => x.Id == formData.Id)
                    .SingleOrDefault();

                product.ProductName = formData.ProductName;
                product.Description = formData.Description;
                product.InStock = formData.InStock;
                product.Active = formData.Active;
                product.CategoryId = formData.CategoryId;

                if (fileImage != null)
                {
                    string filePath = Server.MapPath("~/Contents/Images/" + fileImage.FileName);
                    fileImage.SaveAs(filePath);

                    product.ImageUrl = fileImage.FileName;
                }

                context.SaveChanges();

            }

            return RedirectToAction("Index");
        }
    }
}