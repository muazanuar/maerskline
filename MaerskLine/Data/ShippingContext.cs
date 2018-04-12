using MaerskLine.Models;
using Microsoft.EntityFrameworkCore;

namespace MaerskLine.Data
{
    public class ShippingContext : DbContext
    {
        public ShippingContext(DbContextOptions<ShippingContext> options) : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Schedule>().ToTable("Schedule");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}