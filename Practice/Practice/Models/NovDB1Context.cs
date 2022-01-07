using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Practice.Models
{
    public partial class NovDB1Context : DbContext
    {
        public NovDB1Context()
        {
        }

        public NovDB1Context(DbContextOptions<NovDB1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Studentlbl> Studentlbl { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<Table2> Table2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=RAVI\\SQLEXPRESS;Initial Catalog=NovDB1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studentlbl>(entity =>
            {
                entity.HasKey(e => e.RollNumber);

                entity.ToTable("studentlbl");

                entity.Property(e => e.RollNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvgMarks).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Esalary).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasKey(e => e.EmpName);

                entity.ToTable("table2");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marks)
                    .HasColumnName("marks")
                    .HasColumnType("numeric(6, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
