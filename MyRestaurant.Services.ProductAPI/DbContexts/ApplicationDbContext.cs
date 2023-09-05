using Microsoft.EntityFrameworkCore;
using MyRestaurant.Services.ProductAPI.Models;

namespace MyRestaurant.Web.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/11.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/12.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/13.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/14.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                CategoryName = "Entree"
            });
        }
    }
}
