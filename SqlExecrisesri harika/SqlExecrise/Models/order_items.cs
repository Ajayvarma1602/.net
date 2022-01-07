using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class order_items
    {
        [Key][Column(Order =0)]
        public int Order_Id { get; set; }
        [Required]
        [Key]
        [Column(Order = 1)]
        public int Item_Id { get; set; }
        public int Product_Id { get; set; }
        [ForeignKey("   Product_Id")]
        public virtual products product { get; set; }
        public double Quantity { get; set; }
        public double List_Price { get; set; }
        public int Discount { get; set; }
    }
}
