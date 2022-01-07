using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlmv_Project.Models
{
    public class products
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name{ get; set; }
        public int Brand_Id { get; set; }
        [ForeignKey("Brand_id")]
        public virtual brands brand { get; set; }
        public int Category_Id { get; set; }
        public string Model_Year { get; set; }
        public double List_Price  { get; set; }

    }
}
