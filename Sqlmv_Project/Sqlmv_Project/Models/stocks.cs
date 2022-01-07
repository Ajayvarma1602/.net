using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlmv_Project.Models
{
    public class stocks
    {[Key]
        public int Store_Id { get; set; }
        [Required]
        public int Product_Id { get; set; }
        public double Quantity { get; set; }
    }
}
