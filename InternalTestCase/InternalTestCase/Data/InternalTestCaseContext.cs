using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InternalTestCase.Models;

namespace InternalTestCase.Data
{
    public class InternalTestCaseContext : DbContext
    {
        public InternalTestCaseContext (DbContextOptions<InternalTestCaseContext> options)
            : base(options)
        {
        }

        public DbSet<InternalTestCase.Models.Employee> Employee { get; set; }

        public DbSet<InternalTestCase.Models.Department> Department { get; set; }

        public DbSet<InternalTestCase.Models.Insurance> Insurance { get; set; }
    }
}
