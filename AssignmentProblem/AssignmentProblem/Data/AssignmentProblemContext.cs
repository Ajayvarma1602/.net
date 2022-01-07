using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentProblem.Models;

namespace AssignmentProblem.Data
{
    public class AssignmentProblemContext : DbContext
    {
        public AssignmentProblemContext (DbContextOptions<AssignmentProblemContext> options)
            : base(options)
        {
        }

        public DbSet<AssignmentProblem.Models.Employee> Employee { get; set; }

        public DbSet<AssignmentProblem.Models.Department> Department { get; set; }

        public DbSet<AssignmentProblem.Models.Insurance> Insurance { get; set; }
    }
}
