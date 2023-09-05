using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyRestaurant.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://daslamstorage.blob.core.windows.net/myrestaurantblob/11.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D", "Samosa", 15.0 },
                    { 2, "Appetizer", "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://daslamstorage.blob.core.windows.net/myrestaurantblob/12.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D", "Paneer Tikka", 13.99 },
                    { 3, "Dessert", "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://daslamstorage.blob.core.windows.net/myrestaurantblob/13.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D", "Sweet Pie", 10.99 },
                    { 4, "Entree", "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://daslamstorage.blob.core.windows.net/myrestaurantblob/14.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D", "Pav Bhaji", 15.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
