using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationPractice.Models;

namespace WebApplicationPractice.Data
{
    public class WebApplicationPracticeContext : DbContext
    {
        public WebApplicationPracticeContext (DbContextOptions<WebApplicationPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationPractice.Models.StudentDetails> StudentDetails { get; set; }
    }
}
