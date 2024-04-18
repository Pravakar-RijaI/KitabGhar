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
    }
}
