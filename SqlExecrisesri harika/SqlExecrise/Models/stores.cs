using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class stores
    {
        [Key]
        public int Store_Id { get; set; }
        [DisplayName("Store Name")]
        public String Store_Name { get; set; }
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
