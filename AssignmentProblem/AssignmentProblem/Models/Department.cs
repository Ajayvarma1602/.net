using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AssignmentProblem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }

        [DisplayName("Department Location")]
        public string DepartmentLocation { get; set; }
        
       


    }
}
