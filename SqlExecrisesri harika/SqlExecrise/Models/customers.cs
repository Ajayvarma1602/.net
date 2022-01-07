using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class customers
    {
        [Key]
        public int Customer_Id { get; set; }
        [DisplayName("First Name")]
        public string First_Name { get; set; }
        [DisplayName("Last Name")]
        public string Last_Name { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}
