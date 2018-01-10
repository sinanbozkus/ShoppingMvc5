using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.DataAccess.Models;

namespace Shopping.DataAccess.Context
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base("Server=.;Database=ShoppingDb;User Id=sa; Password = 123;")
        {

        }

        public DbSet<Category> CategoryTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
        public DbSet<User> UserTable { get; set; }

    }
}
