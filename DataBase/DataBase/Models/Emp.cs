﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Models
{
    public partial class Emp
    {
        public int Empno { get; set; }
        public string EmpName { get; set; }
        public decimal? EmpSalary { get; set; }
    }
}
