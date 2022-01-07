using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sqlmv_Project.Models;

namespace Sqlmv_Project.Data
{
    public class Sqlmv_ProjectContext : DbContext
    {
        public Sqlmv_ProjectContext (DbContextOptions<Sqlmv_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Sqlmv_Project.Models.customers> customers { get; set; }

        public DbSet<Sqlmv_Project.Models.orders> orders { get; set; }

        public DbSet<Sqlmv_Project.Models.brands> brands { get; set; }

        public DbSet<Sqlmv_Project.Models.categories> categories { get; set; }

        public DbSet<Sqlmv_Project.Models.order_items> order_items { get; set; }

        public DbSet<Sqlmv_Project.Models.products> products { get; set; }

        public DbSet<Sqlmv_Project.Models.staffs> staffs { get; set; }

        public DbSet<Sqlmv_Project.Models.stocks> stocks { get; set; }

        public DbSet<Sqlmv_Project.Models.stores> stores { get; set; }
    }
}
