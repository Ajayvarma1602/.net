using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Models
{
    public partial class Product
    {
        public Product()
        {
            Bill = new HashSet<Bill>();
        }

        public int Pid { get; set; }
        public string Pname { get; set; }

        public virtual ICollection<Bill> Bill { get; set; }
    }
}
