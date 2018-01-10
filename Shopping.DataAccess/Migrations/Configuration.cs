namespace Shopping.DataAccess.Migrations
{
    using Shopping.DataAccess.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shopping.DataAccess.Context.ShoppingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Shopping.DataAccess.Context.ShoppingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            User user = new User();
            user.Id = 1;
            user.Firstname = "Sinan";
            user.Lastname = "Bozkuþ";
            user.Username = "Admin";
            user.Password = "123";
            user.Active = true;

            context.UserTable.AddOrUpdate(x => x.Id, user);


            Category cat1 = new Category();
            cat1.Id = 1;
            cat1.CategoryName = "Computers";
            cat1.Active = true;

            context.CategoryTable.AddOrUpdate(x => x.Id, cat1);

            Category cat2 = new Category();
            cat2.Id = 2;
            cat2.CategoryName = "Phones";
            cat2.Active = true;

            context.CategoryTable.AddOrUpdate(x => x.Id, cat2);

            Category cat3 = new Category();
            cat3.Id = 3;
            cat3.CategoryName = "Clothes";
            cat3.Active = false;

            context.CategoryTable.AddOrUpdate(x => x.Id, cat3);

            Category cat4 = new Category();
            cat4.Id = 4;
            cat4.CategoryName = "Games";
            cat4.Active = true;

            context.CategoryTable.AddOrUpdate(x => x.Id, cat4);

            Product prd1 = new Product();
            prd1.ProductName = "iPhone X";
            prd1.Description = "Apple";
            prd1.Active = true;
            prd1.InStock = 10;
            prd1.CategoryId = cat2.Id;

            context.ProductTable.AddOrUpdate(x => x.Id, prd1);

            Product prd2 = new Product();
            prd2.ProductName = "iPhone 8";
            prd2.Description = "Apple";
            prd2.Active = true;
            prd2.InStock = 5;
            prd2.CategoryId = cat2.Id;

            context.ProductTable.AddOrUpdate(x => x.Id, prd2);

            Product prd3 = new Product();
            prd3.ProductName = "Galaxy Note";
            prd3.Description = "Samsung";
            prd3.Active = false;
            prd3.InStock = 0;
            prd3.CategoryId = cat2.Id;

            context.ProductTable.AddOrUpdate(x => x.Id, prd3);

            Product prd4 = new Product();
            prd4.ProductName = "Asus Laptop";
            prd4.Active = true;
            prd4.InStock = 50;
            prd4.CategoryId = cat1.Id;

            context.ProductTable.AddOrUpdate(x => x.Id, prd4);
        }
    }
}
