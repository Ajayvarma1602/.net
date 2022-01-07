using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExecrise.Models
{
    public class categories
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
    }
}
