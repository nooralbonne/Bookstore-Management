using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookstore_Management.Migrations
{
    /// <inheritdoc />
    public partial class AddBooksData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Classic", 10.99m, "The Great Gatsby" },
                    { 2, "Harper Lee", "Fiction", 12.99m, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "Dystopian", 14.99m, "1984" },
                    { 4, "Herman Melville", "Adventure", 11.99m, "Moby Dick" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
