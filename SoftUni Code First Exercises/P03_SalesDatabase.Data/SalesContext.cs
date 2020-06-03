using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public SalesContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configure.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureSaleEntity(modelBuilder);
        }

        private void ConfigureSaleEntity(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Sale>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Sales);

            modelBuilder
                .Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales);

            modelBuilder
                .Entity<Sale>()
                .HasOne(s => s.Store)
                .WithMany(st => st.Sales);
        }
    }
}
