using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore01.Configration;
using EFCore01.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCore01.Context
{


    internal class AppDbContext : DbContext
    {
        public AppDbContext() :base(){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E.HasKey(E => E.EmpId);
            //    E.Property(E => E.EmpId).UseIdentityColumn(1, increment: 1);
            //});

            modelBuilder.ApplyConfiguration(new EmployeeCofigurations());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppG01;Trusted_Connection = True;TrustServerCertificate = True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> departments { get; set; }

    }
}

