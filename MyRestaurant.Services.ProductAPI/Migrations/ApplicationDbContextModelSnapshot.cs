﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyRestaurant.Web.DbContexts;

#nullable disable

namespace MyRestaurant.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyRestaurant.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Appetizer",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/11.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                            Name = "Samosa",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Appetizer",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/12.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                            Name = "Paneer Tikka",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Dessert",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/13.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                            Name = "Sweet Pie",
                            Price = 10.99
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Entree",
                            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                            ImageUrl = "https://daslamstorage.blob.core.windows.net/myrestaurantblob/14.jpg?sp=r&st=2023-09-05T07:23:30Z&se=2023-09-30T15:23:30Z&sv=2022-11-02&sr=c&sig=7azA2ZGCBPl2qUbdKy3uEDKABNFfYIOj3XEBEUfWgMU%3D",
                            Name = "Pav Bhaji",
                            Price = 15.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
