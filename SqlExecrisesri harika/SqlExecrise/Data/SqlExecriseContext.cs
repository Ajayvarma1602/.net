using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SqlExecrise.Models;

namespace SqlExecrise.Data
{
    public class SqlExecriseContext : DbContext
    {
        public SqlExecriseContext (DbContextOptions<SqlExecriseContext> options)
            : base(options)
        {
        }

        public DbSet<SqlExecrise.Models.customers> customers { get; set; }

        public DbSet<SqlExecrise.Models.stores> stores { get; set; }

        public DbSet<SqlExecrise.Models.staffs> staffs { get; set; }
    }
}
