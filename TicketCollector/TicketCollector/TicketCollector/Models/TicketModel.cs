using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketCollector.Models
{
    public class TicketModel
    {
        [Required]
        [Display(Name = "Ticket Number")]
        public string TicketNo { get; set; }
        
        [Required]
        [Display(Name = "Ticket Color")]
        public string TicketColor { get; set; }
        [Display(Name = "Issuer Name")]

        public string IssuerName { get; set; }
        [Display(Name = "Receiver Id")]
        public string ReceiverId { get; set; }
        public string Day { get; set; }
    }
}
