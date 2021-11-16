using TestWebApp.Models;
using Microsoft.EntityFrameworkCore;
namespace TestWebApp.Data
{
    public class ObjectContext : DbContext
    {
        public ObjectContext(DbContextOptions<ObjectContext> options)
    : base(options)
        {
        }

        public DbSet<TestWebApp.Models.Product> Product { get; set; }
        public DbSet<TestWebApp.Models.Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}
