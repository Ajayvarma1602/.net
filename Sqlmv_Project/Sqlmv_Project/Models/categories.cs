﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlmv_Project.Models
{
    public class categories
    {[Key]
        public int Category_Id { get; set; }
        [DisplayName("Category Name")]
        public string Category_Name  { get; set; }

    }
}
