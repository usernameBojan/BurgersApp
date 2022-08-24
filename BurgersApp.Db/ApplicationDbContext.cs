using BurgersApp.Db.EntityFramework.EntityTypeConfiguration;
using BurgersApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgersApp.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BurgersTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LocationsTypeConfiguration());
        }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }        
    }
}