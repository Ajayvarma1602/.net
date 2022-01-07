using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Models
{
    public partial class BasicDBContext : DbContext
    {
        public BasicDBContext()
        {
        }

        public BasicDBContext(DbContextOptions<BasicDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<Table2> Table2 { get; set; }
        public virtual DbSet<Table3> Table3 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=RAVI\\SQLEXPRESS;Initial Catalog=BasicDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.Billno);

                entity.Property(e => e.Billno)
                    .HasColumnName("billno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Billdetails)
                    .HasColumnName("billdetails")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("FK_Bill_Customer");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_Bill_PRODUCT");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Customerid)
                    .HasColumnName("customerid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Deptid);

                entity.Property(e => e.Deptid)
                    .HasColumnName("deptid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deptname)
                    .HasColumnName("deptname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno);

                entity.ToTable("EMP");

                entity.Property(e => e.Empno).ValueGeneratedNever();

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSalary).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.Property(e => e.Empid)
                    .HasColumnName("empid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Empname)
                    .HasColumnName("empname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Employee_Department");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("PRODUCT");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.StudentAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentMarks).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_2");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rollno).HasColumnName("rollno");

                entity.Property(e => e.Sgrade)
                    .HasColumnName("sgrade")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Smarks)
                    .HasColumnName("smarks")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table3>(entity =>
            {
                entity.HasKey(e => e.Rno);

                entity.ToTable("Table_3");

                entity.Property(e => e.Rno)
                    .HasColumnName("rno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Add)
                    .HasColumnName("add")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
