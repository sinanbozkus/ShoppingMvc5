using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
