using Shopping.DataAccess.Context;
using Shopping.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.WebUI.Areas.admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: admin/Category
        public ActionResult Index()
        {
            ShoppingContext context = new ShoppingContext();

            List<Category> categoryList = context.CategoryTable.ToList();

            return View(categoryList);
        }

        public ActionResult Add()
        {
            return View("Form");
        }

        public ActionResult Edit(int id)
        {
            ShoppingContext context = new ShoppingContext();

            Category category =
                context.CategoryTable.Where(x => x.Id == id).SingleOrDefault();

            return View("Form", category);

            //List<Category> categoryList = context.CategoryTable.ToList();

            //Category selectedCategory = null;

            //foreach (Category item in categoryList)
            //{
            //    if(item.Id == id)
            //    {
            //        selectedCategory = item;
            //    }
            //}

            //return View("Form", selectedCategory);
        }

        public ActionResult Save(Category formData)
        {
            ShoppingContext context = new ShoppingContext();

            if(formData.Id == 0)
            {
                // id 0 sa insert işlemidir.

                context.CategoryTable.Add(formData);
                context.SaveChanges();
            }
            else
            {
                // id si 0 değilse update işlemidir.

                Category category
                    = context.CategoryTable.Where(x => x.Id == formData.Id).SingleOrDefault();

                category.CategoryName = formData.CategoryName;
                category.Description = formData.Description;
                category.Active = formData.Active;

                context.SaveChanges();


            }

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            ShoppingContext context = new ShoppingContext();

            Category category
                = context.CategoryTable.Where(x => x.Id == id).SingleOrDefault();

            context.CategoryTable.Remove(category);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}