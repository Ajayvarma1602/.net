using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SqlExcercise.Models
{
    //public class SampleContext : DbContext
    //{
    //    public DbSet<order_items> Orders { get; set; }
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<order_items>()
    //            .HasKey(o => new { o.Order_Id, o.Item_Id });
    //    }
    //}
    public class order_items
    { 
      //  [Key]
       //[Key][Column(Order=0)]
        //[System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
        public int Order_Id { get; set; }
        [Required]
       //[Key][Column(Order =1)]
       // [Key]
        public int Item_Id { get; set; }

        public int Product_Id { get; set; }
        [ForeignKey("Product_Id")]
        public virtual products product { get; set; }
        public double Quantity { get; set; }
        public double List_Price { get; set; }
        public int Discount { get; set; }

    }
}
