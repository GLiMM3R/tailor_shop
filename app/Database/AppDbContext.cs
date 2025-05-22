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
        public DbSet<DailySequence> DailySequences { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Fabric> Fabrics { get; set; }
        public DbSet<Garment> Garments { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
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

            modelBuilder.Entity<Customer>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasIndex(o => o.OrderNumber)
                .IsUnique();

            modelBuilder.Entity<Order>()
                .HasMany(u => u.Measurements)
                .WithOne(o => o.Order)
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Payments)
                .WithOne()
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // or Restrict, SetNull, etc.

            modelBuilder.Entity<User>().HasData(
                 new User { Id = 1, Username = "admin", Password = passwordString, Salt = saltString, Role = Role.Admin });

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Esther Lynn", Gender = Gender.Male, Phone = "77919430", Address = "tanmixay" });
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    string passwordString = "+ME1Cq0n2uJ85+H3gHkewnzYDGM5IsRwQDfOJZ4Mly4=";
        //    string saltString = "VbQId3K5ZFNKRRSaL8rdvw==";

        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Orders)
        //        .WithOne(o => o.User)
        //        .HasForeignKey(o => o.UserId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Customer>()
        //        .HasMany(c => c.Orders)
        //        .WithOne(o => o.Customer)
        //        .HasForeignKey(o => o.CustomerId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Order>()
        //        .HasOne(o => o.Fabric)
        //        .WithMany(f => f.Orders)
        //        .HasForeignKey(o => o.FabricId)
        //        .OnDelete(DeleteBehavior.Restrict); // or Cascade, SetNull, etc.

        //    modelBuilder.Entity<Order>()
        //        .HasOne(o => o.Garment)
        //        .WithMany(f => f.Orders)
        //        .HasForeignKey(o => o.GarmentId)
        //        .OnDelete(DeleteBehavior.Restrict); // or Cascade, SetNull, etc.

        //    modelBuilder.Entity<Order>()
        //        .HasMany(o => o.Measurements)
        //        .WithOne(f => f.Order)
        //        .HasForeignKey(o => o.OrderId)
        //        .OnDelete(DeleteBehavior.Restrict); // or Cascade, SetNull, etc.

        //    modelBuilder.Entity<Fabric>()
        //        .HasMany(f => f.Orders)
        //        .WithOne(o => o.Fabric)
        //        .HasForeignKey(o => o.FabricId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Garment>()
        //        .HasMany(g => g.Orders)
        //        .WithOne(o => o.Garment)
        //        .HasForeignKey(o => o.GarmentId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Order>()
        //        .HasIndex(o => o.OrderNumber)
        //        .IsUnique();

        //    modelBuilder.Entity<Payment>()
        //        .HasOne(m => m.Order)
        //        .WithMany(o => o.Payments)
        //        .HasForeignKey(m => m.OrderId)
        //        .OnDelete(DeleteBehavior.Cascade); // or Restrict, SetNull, etc.

        //    modelBuilder.Entity<Measurement>()
        //        .HasOne(m => m.Order)
        //        .WithMany(o => o.Measurements)
        //        .HasForeignKey(m => m.OrderId)
        //        .OnDelete(DeleteBehavior.Cascade); // or Restrict, SetNull, etc.


        //    modelBuilder.Entity<User>().HasData(
        //         new User { Id = 1, Username = "admin", Password = passwordString, Salt = saltString, Role = Role.Admin });

        //    modelBuilder.Entity<Customer>().HasData(
        //        new Customer { Id = 1, Name = "Esther Lynn", Gender = Gender.Male, Phone = "77919430", Address = "tanmixay" });
        //}
    }
}
