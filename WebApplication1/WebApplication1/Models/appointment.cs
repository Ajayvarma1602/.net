using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class appointment
    {
        [Required]
        public int AppointmentId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Severity { get; set; }
        [Required]
        public DateTime AppointmentRequestDate { get; set; }
        public string Slot { get; set; }
        public string MobileNo { get; set; }

    }
}
