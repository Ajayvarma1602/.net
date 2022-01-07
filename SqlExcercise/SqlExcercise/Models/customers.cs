using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExcercise.Models
{
    public class customers
    {
        [Key]
        public int Customer_Id { get; set; }
        [DisplayName("First Name")]
        public string Frist_Name { get; set; }
        [DisplayName("Second Name")]
        public string Last_Name { get; set; }
        [DisplayName("Phone Number")]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode{get; set;}
        }
}
