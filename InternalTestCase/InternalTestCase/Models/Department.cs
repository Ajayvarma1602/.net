using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalTestCase.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }
        [DisplayName("Department Location")]

        public string DepartmentLocation { get; set; }
        [Required]
        public string DepartmentCode { get; set; }

    }
}
