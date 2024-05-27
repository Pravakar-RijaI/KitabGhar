using KitabGhar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KitabGhar.Areas.Identity.Data;

namespace KitabGhar.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


            modelBuilder.Entity<CategoryModel>().HasData(
            new CategoryModel { CategoryId = 1, CategoryName = "Fiction", DisplayOrder = 1},
            new CategoryModel { CategoryId = 2, CategoryName = "Fantasy", DisplayOrder = 2},
            new CategoryModel { CategoryId = 3, CategoryName = "Self-Help", DisplayOrder = 3},
            new CategoryModel { CategoryId = 4, CategoryName = "Romance", DisplayOrder = 4},
            new CategoryModel { CategoryId = 5, CategoryName = "Thriller", DisplayOrder = 5}
            );

            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { Id = 1, Title = "Atomic Habits", Author = "James Clear", Description = "Self help books containing tried and tested ways for changing habits.", ISBN = "SWD9999001", Price = 650, CategoryId = 3, ImageUrl = "/images/Atomic_Habits.jpg" },
                new ProductModel { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Description = "A classic novel that explores racial injustice and moral growth in the American South.", ISBN = "B00K4B1W7U", Price = 1200, CategoryId = 1, ImageUrl = "/images/To_Kill_A_Mockingbird.jpg" },
                new ProductModel { Id = 3, Title = "1984", Author = "George Orwell", Description = "A dystopian novel set in a totalitarian society where independent thought is suppressed.", ISBN = "B003JTHWKU", Price = 1500, CategoryId = 1, ImageUrl = "/images/1984.jpg" },
                new ProductModel { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Description = "A timeless romance novel featuring the headstrong Elizabeth Bennet and the enigmatic Mr. Darcy.", ISBN = "B008476HBM", Price = 1000, CategoryId = 4, ImageUrl = "/images/Pride_And_Prejudice.jpg" },
                new ProductModel { Id = 5, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Description = "A Jazz Age novel that delves into themes of wealth, love, and the American Dream.", ISBN = "B00JH1T8JG", Price = 1400, CategoryId = 1, ImageUrl = "/images/The_Great_Gatsby.jpg" },
                new ProductModel { Id = 6, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Description = "A coming-of-age novel following the rebellious Holden Caulfield.", ISBN = "B003JTHWKU", Price = 1100, CategoryId = 1, ImageUrl = "/images/The_Catcher_in_the_Rye.jpg" },
                new ProductModel { Id = 7, Title = "The Hobbit", Author = "J.R.R. Tolkien", Description = "A fantasy adventure about Bilbo Baggins and his quest for treasure.", ISBN = "B007978OY6", Price = 1300, CategoryId = 2, ImageUrl = "/images/The_Hobbit.jpg" },
                new ProductModel { Id = 8, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", Description = "The first book in the beloved Harry Potter series, filled with magic, friendship, and adventure.", ISBN = "B0192CTMX0", Price = 2000, CategoryId = 2, ImageUrl = "/images/Harry_Potter.jpg" },
                new ProductModel { Id = 9, Title = "The Lord of the Rings: The Fellowship of the Ring", Author = "J.R.R. Tolkien", Description = "The epic fantasy saga begins with a journey to destroy a powerful ring.", ISBN = "B007978OY6", Price = 1800, CategoryId = 2, ImageUrl = "/images/Lord_of_the_Rings.jpg" },
                new ProductModel { Id = 10, Title = "The Alchemist", Author = "Paulo Coelho", Description = "A philosophical novel about a shepherd boy's quest for treasure and self-discovery.", ISBN = "B00U6SFUSS", Price = 900, CategoryId = 1, ImageUrl = "/images/The_Alchemist.jpg" },
                new ProductModel { Id = 11, Title = "The Road", Author = "Cormac McCarthy", Description = "A post-apocalyptic novel following a father and son's journey through a desolate landscape.", ISBN = "B002RI9WUQ", Price = 1600, CategoryId = 1, ImageUrl = "/images/The_Road.jpg" },
                new ProductModel { Id = 12, Title = "The Kite Runner", Author = "Khaled Hosseini", Description = "A powerful story of friendship, betrayal, and redemption set in Afghanistan.", ISBN = "B000OCXF6W", Price = 1300, CategoryId = 1, ImageUrl = "/images/The_Kite_Runner.jpg" },
                new ProductModel { Id = 13, Title = "The Book Thief", Author = "Markus Zusak", Description = "A novel narrated by Death, centered around a young girl during World War II.", ISBN = "B001NLKT2M", Price = 1400, CategoryId = 1, ImageUrl = "/images/The_Book_Thief.jpg" },
                new ProductModel { Id = 14, Title = "The Hunger Games", Author = "Suzanne Collins", Description = "The first book in a dystopian trilogy where teenagers fight to the death in a televised event.", ISBN = "B002MQYOFW", Price = 1100, CategoryId = 1, ImageUrl = "/images/The_Hunger_Games.jpg" },
                new ProductModel { Id = 15, Title = "The Da Vinci Code", Author = "Dan Brown", Description = "A thrilling mystery involving art, religion, and secret societies.", ISBN = "B000FA5T3K", Price = 1200, CategoryId = 5, ImageUrl = "/images/The_Da_Vinci_Code.jpg" }
        );
    }           
  }
}
