using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class NorthwindContext:DbContext //context nesnesi db tabloları ile classları bağlar
	{

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //proje hangi veri tabanı ile ilişikili belirttiğimiz yer.
        {
            optionsBuilder.UseSqlServer(@"Server=server;Database=Northwind;TrustServerCertificate=True;Encrypt=False;");
        }
        //@ kullanmamızın nedeni \ işaretini tek seferde anlaması @ kullanmazsak \\ yapmamız gerekir tek \ işareti için
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            //fluent coding
            modelBuilder.Entity<Customer>().Property(p => p.CustomerId).HasColumnName("CustomerID");
        }
    }
}

