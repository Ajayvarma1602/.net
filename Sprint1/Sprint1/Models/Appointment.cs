using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Models
{
    public class Appointment
    {
        [Required]
        public int Appointmentid { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string  serverity { get; set; }
        public DateTime AppiontmentRequestdate { get; set; }
        public string Slot { get; set; }
        public string MobileNo { get; set; }
    }
}
