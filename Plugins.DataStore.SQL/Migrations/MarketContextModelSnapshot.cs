﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataStore.SQL;

namespace Plugins.DataStore.SQL.Migrations
{
    [DbContext(typeof(MarketContext))]
    partial class MarketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsForChildren")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsLegalForEveryone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecommendedAge")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "+18 stuff",
                            IsForChildren = "No",
                            IsLegalForEveryone = "No",
                            Name = "Alcohol",
                            RecommendedAge = "5"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Sweets",
                            IsForChildren = "Yes",
                            IsLegalForEveryone = "Yes",
                            Name = "Sweets",
                            RecommendedAge = "6"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Bread",
                            IsForChildren = "Yes",
                            IsLegalForEveryone = "Yes",
                            Name = "Bakery",
                            RecommendedAge = "5"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("Quanity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Russian Vodka",
                            Name = "Vodka",
                            Price = 5.4500000000000002,
                            Quanity = 500
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Description = "Bonibons",
                            Name = "M&M",
                            Price = 2.4500000000000002,
                            Quanity = 90
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            Description = "Wheat Bread",
                            Name = "Bread",
                            Price = 0.55000000000000004,
                            Quanity = 100
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "Swedish Beer",
                            Name = "Beer",
                            Price = 0.45000000000000001,
                            Quanity = 455
                        });
                });

            modelBuilder.Entity("CoreBusiness.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeforeQty")
                        .HasColumnType("int");

                    b.Property<string>("CashierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoldQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.HasOne("CoreBusiness.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
