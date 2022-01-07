using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlmv_Project.Models
{
    public class orders
    {
        [Key]
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }
        [ForeignKey("Customer_Id")]
        public virtual customers customer { get; set; }
        public string Order_Status { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Requried_Date  { get; set; }
        public DateTime Shipped_Date { get; set; }
        public int Store_Id { get; set; }
        [ForeignKey("Store_Id")]
        public virtual stores store { get; set; }
        public int Staff_Id { get; set; }
        [ForeignKey("Staff_Id")]
        public virtual staffs staff { get; set; }


    }
}
