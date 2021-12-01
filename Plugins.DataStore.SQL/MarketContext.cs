using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                  .HasMany(c => c.Products)
                  .WithOne(p => p.Category)
                  .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                //Category Alcohol
                new Category
                {
                    CategoryId = 1,
                    Name = "Alcohol",
                    Description = "+18 stuff",
                    IsLegalForEveryone = "No",
                    IsForChildren = "No",
                    RecommendedAge = "5"
                },

                //Category Sweets
                new Category
                {
                    CategoryId = 2,
                    Name = "Sweets",
                    Description = "Sweets",
                    IsLegalForEveryone = "Yes",
                    IsForChildren = "Yes",
                    RecommendedAge = "6"
                },

                //Category Bakery
                new Category
                {
                    CategoryId = 3,
                    Name = "Bakery",
                    Description = "Bread",
                    IsLegalForEveryone = "Yes",
                    IsForChildren = "Yes",
                    RecommendedAge = "5"
                }
                );

            modelBuilder.Entity<Product>().HasData(

                 new Product { ProductId = 1, CategoryId = 1, Name = "Vodka", Quanity = 500, Price = 5.45, Description = "Russian Vodka" },
                 new Product { ProductId = 2, CategoryId = 2, Name = "M&M", Quanity = 90, Price = 2.45, Description = "Bonibons" },
                 new Product { ProductId = 3, CategoryId = 3, Name = "Bread", Quanity = 100, Price = 0.55, Description = "Wheat Bread" },
                 new Product { ProductId = 4, CategoryId = 1, Name = "Beer", Quanity = 455, Price = 0.45, Description = "Swedish Beer" }

                );
        }
    }
}
