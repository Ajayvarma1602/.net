using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class staffs
    {
        [Key]
        public int Staff_Id { get; set; }
        [DisplayName("First Name")]
        public string First_Name { get; set; }
        [DisplayName("Last Name")]

        public string Last_Name { get; set; }

        public string Email { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        public string Phone { get; set; }
        public string Active { get; set; }
       
        public int Store_Id { get; set; }
        [ForeignKey("Store_Id")]
        public virtual stores store { get; set; }
        [DisplayName("Manager Id")]
        [Required]
        public int Manager_Id { get; set; }
    }
}
