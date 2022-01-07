using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlmv_Project.Models
{
    public class staffs
    {
        [Key]
        public int Staff_Id { get; set; }
        public string Frist_Name { get; set; }
       
        public string Last_Name { get; set; }
        
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Active { get; set; }
        public int Store_Id { get; set; }
        public int Manager_Id { get; set; }
    }
}
