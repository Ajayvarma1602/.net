using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class orders
    {
        [Key]
        public int Order_Id { get; set; }
        [DisplayName("Customer Id")]
        public int Customer_Id { get; set; }
        [ForeignKey("Customer_Id")]
        public virtual customers customer { get; set; }
        [Required]
        [DisplayName("Order Status")]
        
        public string Order_Status { get; set; }
        [Required]
        public DateTime Order_Date { get; set; }
        public DateTime Requried_Date { get; set; }
        [Required]
        [DisplayName("Shipped Date")]
        public DateTime Shipped_Date { get; set; }
        [DisplayName("Store Id")]
        public int Store_Id { get; set; }
        [ForeignKey("Store_Id")]
        public virtual stores store { get; set; }
        [DisplayName("Staff Id")]
        public int Staff_Id { get; set; }
        [ForeignKey("Staff_Id")]
        public virtual staffs staff { get; set; }

    }
}
