using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bill = new HashSet<Bill>();
        }

        public int Customerid { get; set; }
        public string Customername { get; set; }

        public virtual ICollection<Bill> Bill { get; set; }
    }
}
