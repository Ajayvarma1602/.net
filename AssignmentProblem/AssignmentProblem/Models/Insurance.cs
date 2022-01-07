using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AssignmentProblem.Models
{
    public class Insurance
    {
        [Key]
        [Required]
        public int InsuranceId { get; set; }

        public string InsuranceName { get; set; }

        public double  InsuranceAmount { get; set; }

      
    }
}
