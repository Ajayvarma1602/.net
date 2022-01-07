using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Models
{
    public partial class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public decimal? Salary { get; set; }
        public int? Deptid { get; set; }

        public virtual Department Dept { get; set; }
    }
}
