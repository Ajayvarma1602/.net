using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlmv_Project.Models
{
    public class customers
    {
        [Key]
        public int Customer_Id { get; set; }
        public string Frist_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone { get; set; }
        public string Email{ get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

    }
}
