using KitabGhar.Models;
using Microsoft.EntityFrameworkCore;

namespace KitabGhar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
            new CategoryModel { CategoryId = 1, CategoryName = "Action", DisplayOrder = 1},
            new CategoryModel { CategoryId = 2, CategoryName = "ScFi", DisplayOrder = 2},
            new CategoryModel { CategoryId = 3, CategoryName = "History", DisplayOrder = 3}
            );
        }
    
    }
}
