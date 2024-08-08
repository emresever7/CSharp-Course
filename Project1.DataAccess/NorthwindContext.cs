using Microsoft.EntityFrameworkCore;
using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataAccess
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Personnel> Personnels {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("admin");
            modelBuilder.Entity<Personnel>().ToTable("Employees", "dbo");

            modelBuilder.Entity<Personnel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personnel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personnel>().Property(p => p.Surname).HasColumnName("LastName");

        }
    }
}
