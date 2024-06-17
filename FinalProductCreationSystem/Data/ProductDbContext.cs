using Microsoft.EntityFrameworkCore;
using FinalProductCreationSystem.Model;

namespace FinalProductCreationSystem.Services
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)"); // Adjust precision and scale as per your requirements

            // Additional configurations if needed
        }

    }
}
