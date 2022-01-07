using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalTestCase.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }
        [Required]
        public string EmployeeAddress { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public int InsuranceId { get; set; }

    }
}
