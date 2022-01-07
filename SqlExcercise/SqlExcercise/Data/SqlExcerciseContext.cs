using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SqlExcercise.Models;

namespace SqlExcercise.Data
{
    public class SqlExcerciseContext : DbContext
    {
        public SqlExcerciseContext (DbContextOptions<SqlExcerciseContext> options)
            : base(options)
        {
        }


        public DbSet<SqlExcercise.Models.brands> brands { get; set; }

        public DbSet<SqlExcercise.Models.categories> categories { get; set; }

        public DbSet<SqlExcercise.Models.customers> customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<order_items>()
                .HasKey(o => new { o.Order_Id, o.Item_Id });
            modelBuilder.Entity<stocks>()
                .HasKey(o => new { o.Store_Id, o.Product_Id });
        }

        public DbSet<SqlExcercise.Models.order_items> order_items { get; set; }

        public DbSet<SqlExcercise.Models.orders> orders { get; set; }

        public DbSet<SqlExcercise.Models.products> products { get; set; }

        public DbSet<SqlExcercise.Models.staffs> staffs { get; set; }

        public DbSet<SqlExcercise.Models.stocks> stocks { get; set; }

        public DbSet<SqlExcercise.Models.stores> stores { get; set; }

       
    }
}
