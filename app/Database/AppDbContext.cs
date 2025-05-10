using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Model;
using app.Utils;
using Microsoft.EntityFrameworkCore;

namespace app.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Fabric> Fabrics { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Read from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("Connection string 'DefaultConnection' not found in App.config.");
                }
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string passwordString = "+ME1Cq0n2uJ85+H3gHkewnzYDGM5IsRwQDfOJZ4Mly4=";
            string saltString = "VbQId3K5ZFNKRRSaL8rdvw==";

            //modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = passwordString, Salt = saltString }
            );

            //modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            //modelBuilder.Entity<Order>().HasKey(o => o.Id);
            //modelBuilder.Entity<Fabric>().HasKey(f => f.Id);
            //modelBuilder.Entity<Payment>().HasKey(p => p.Id);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Fabric>()
                .HasMany(f => f.Orders)
                .WithOne(o => o.Fabric)
                .HasForeignKey(o => o.FabricId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Payments)
                .WithOne(p => p.Order)
                .HasForeignKey(p => p.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Esther Lynn", Gender = "male", Phone = "77919430", Address = "tanmixay" });
        }
    }
}
