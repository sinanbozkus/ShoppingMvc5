using Shopping.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.WebUI.Models
{
    public class HomeViewModel
    {
        public List<Product> CarouselProducts { get; set; }
        public List<Product> Products { get; set; }
    }
}