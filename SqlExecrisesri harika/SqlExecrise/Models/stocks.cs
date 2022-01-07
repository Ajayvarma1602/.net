using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class stocks
    {
        [Key][Column("Order=0")]
        public int Store_Id { get; set; }
        [Key]
        [Column("Order=1")]
        public int Product_Id { get; set; }
       
        public double Quantity { get; set; }
    }
}
