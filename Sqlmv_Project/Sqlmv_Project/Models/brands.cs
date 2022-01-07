using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlmv_Project.Models
{
    public class brands
                {[Key]
                    public int Brand_Id { get; set; }
                    public string Brand_Name { get; set; }
                }
}
