using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AssignmentProblem.Models
{
    public class Employee
    {
        [Key]

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public double EmployeeSalary { get; set; }
        [Required]
        public string EmployeeAddress { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public int InsuranceId { get; set; }
    }
}
