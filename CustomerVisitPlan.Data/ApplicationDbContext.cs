using System;
using CustomerVisitPlan.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerVisitPlan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<VisitPlan> VisitPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>()
                .HasOne(o => o.City)
                .WithMany(m => m.Regions).HasForeignKey(k => k.CityId);
            modelBuilder.Entity<Region>()
                .Property(p => p.Name).HasMaxLength(100);

            modelBuilder.Entity<City>()
                .Property(p => p.Name).HasMaxLength(100);

            modelBuilder.Entity<Customer>()
                .HasOne(o => o.City)
                .WithMany(m => m.Customers).HasForeignKey(k => k.CityId);

            modelBuilder.Entity<Customer>()
                .HasOne(o => o.Region)
                .WithMany(m => m.Customers).HasForeignKey(k => k.RegionId);

            modelBuilder.Entity<Customer>()
                .Property(p => p.Name).HasMaxLength(100);
            modelBuilder.Entity<Customer>()
                .Property(p => p.TaxNumber).HasMaxLength(20);
            modelBuilder.Entity<Customer>()
                .Property(p => p.Phone).HasMaxLength(20);

            modelBuilder.Entity<VisitPlan>()
                .HasOne(o => o.Customer)
                .WithMany(m => m.VisitPlans).HasForeignKey(k => k.CustomerId);
        }
    }

}
