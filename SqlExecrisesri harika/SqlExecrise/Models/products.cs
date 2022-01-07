using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class products
    {
        [Key]
        public int Product_Id { get; set; }
        [DisplayName("Product Name")]
        public string Product_Name { get; set; }
        public int Brand_Id { get; set; }
        [DisplayName("Brand Id")]
        [ForeignKey("Brand_Id")]
        public virtual brands brand { get; set; }
        [DisplayName("Category Id")]
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public virtual categories category { get; set; }
        [DisplayName("Model Year")]
        public string Model_Year { get; set; }
        [DisplayName("List Price")]
        public double List_Price { get; set; }
    }
}
