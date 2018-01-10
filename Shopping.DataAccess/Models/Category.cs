using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Models
{
    //[Table("Kategoriler")]
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Category Name is required!")]
        [MaxLength(30)]
        public string CategoryName { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}
