using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExcercise.Models
{
    public class brands
    {
        
        [Key]
        public int Brand_Id { get; set; }   
        [Required]
        [DisplayName("Brand Name")]
        public string Brand_Name { get; set; }
    }
}

