using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Models
{
    public partial class Bill
    {
        [Key]
        public int Id { get; set; }
        public int Billno { get; set; }
        public string Billdetails { get; set; }
        
        public int? Pid { get; set; }
        public int? Customerid { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product P { get; set; }
    }
}
