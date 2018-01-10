using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Models
{
    //[Table("Urunler")]
    public class Product : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        [Required]
        public int InStock { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
