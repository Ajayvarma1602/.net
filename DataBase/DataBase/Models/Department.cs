using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public int Deptid { get; set; }
        public string Deptname { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
