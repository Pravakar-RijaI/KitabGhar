using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KitabGhar.Migrations
{
    /// <inheritdoc />
    public partial class CreateandUpdatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "DisplayOrder" },
                values: new object[,]
                {
                    { 1, "Fiction", 1 },
                    { 2, "Fantasy", 2 },
                    { 3, "Self-Help", 3 },
                    { 4, "Romance", 4 },
                    { 5, "Thriller", 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "James Clear", 3, "Self help books containing tried and tested ways for changing habits.", "SWD9999001", "/images/Atomic_Habits.jpg", 650.0, "Atomic Habits" },
                    { 2, "Harper Lee", 1, "A classic novel that explores racial injustice and moral growth in the American South.", "B00K4B1W7U", "/images/To_Kill_A_Mockingbird.jpg", 1200.0, "To Kill a Mockingbird" },
                    { 3, "George Orwell", 1, "A dystopian novel set in a totalitarian society where independent thought is suppressed.", "B003JTHWKU", "/images/1984.jpg", 1500.0, "1984" },
                    { 4, "Jane Austen", 4, "A timeless romance novel featuring the headstrong Elizabeth Bennet and the enigmatic Mr. Darcy.", "B008476HBM", "/images/Pride_And_Prejudice.jpg", 1000.0, "Pride and Prejudice" },
                    { 5, "F. Scott Fitzgerald", 1, "A Jazz Age novel that delves into themes of wealth, love, and the American Dream.", "B00JH1T8JG", "/images/The_Great_Gatsby.jpg", 1400.0, "The Great Gatsby" },
                    { 6, "J.D. Salinger", 1, "A coming-of-age novel following the rebellious Holden Caulfield.", "B003JTHWKU", "/images/The_Catcher_in_the_Rye.jpg", 1100.0, "The Catcher in the Rye" },
                    { 7, "J.R.R. Tolkien", 2, "A fantasy adventure about Bilbo Baggins and his quest for treasure.", "B007978OY6", "/images/The_Hobbit.jpg", 1300.0, "The Hobbit" },
                    { 8, "J.K. Rowling", 2, "The first book in the beloved Harry Potter series, filled with magic, friendship, and adventure.", "B0192CTMX0", "/images/Harry_Potter.jpg", 2000.0, "Harry Potter and the Sorcerer's Stone" },
                    { 9, "J.R.R. Tolkien", 2, "The epic fantasy saga begins with a journey to destroy a powerful ring.", "B007978OY6", "/images/Lord_of_the_Rings.jpg", 1800.0, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 10, "Paulo Coelho", 1, "A philosophical novel about a shepherd boy's quest for treasure and self-discovery.", "B00U6SFUSS", "/images/The_Alchemist.jpg", 900.0, "The Alchemist" },
                    { 11, "Cormac McCarthy", 1, "A post-apocalyptic novel following a father and son's journey through a desolate landscape.", "B002RI9WUQ", "/images/The_Road.jpg", 1600.0, "The Road" },
                    { 12, "Khaled Hosseini", 1, "A powerful story of friendship, betrayal, and redemption set in Afghanistan.", "B000OCXF6W", "/images/The_Kite_Runner.jpg", 1300.0, "The Kite Runner" },
                    { 13, "Markus Zusak", 1, "A novel narrated by Death, centered around a young girl during World War II.", "B001NLKT2M", "/images/The_Book_Thief.jpg", 1400.0, "The Book Thief" },
                    { 14, "Suzanne Collins", 1, "The first book in a dystopian trilogy where teenagers fight to the death in a televised event.", "B002MQYOFW", "/images/The_Hunger_Games.jpg", 1100.0, "The Hunger Games" },
                    { 15, "Dan Brown", 5, "A thrilling mystery involving art, religion, and secret societies.", "B000FA5T3K", "/images/The_Da_Vinci_Code.jpg", 1200.0, "The Da Vinci Code" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
