using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalTestCase.Models
{
    public class Insurance
    {
        [Key]
        [Required]
        public int InsuranceId { get; set; }
        [Required]
        [DisplayName("Insurance Name")]
        public string InsuranceName { get; set; }
        public double InsuranceAmount { get; set; }
        [Required]
        public double InsuranceDuration { get; set; }
    }
}
