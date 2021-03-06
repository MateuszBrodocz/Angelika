﻿// <auto-generated />
using System;
using Codecool.OnlineStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Codecool.OnlineStore.Migrations
{
    [DbContext(typeof(AllegrettoContext))]
    partial class AllegrettoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Codecool.OnlineStore.Model.BasketItem", b =>
                {
                    b.Property<int>("BasketItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BasketItemId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketItem");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Albania"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Andorra"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Armenia"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "Austria"
                        },
                        new
                        {
                            CountryId = 5,
                            CountryName = "Azerbaijan"
                        },
                        new
                        {
                            CountryId = 6,
                            CountryName = "Belarus"
                        },
                        new
                        {
                            CountryId = 7,
                            CountryName = "Belgium"
                        },
                        new
                        {
                            CountryId = 8,
                            CountryName = "Bosnia and Herzegovina"
                        },
                        new
                        {
                            CountryId = 9,
                            CountryName = "Bulgaria"
                        },
                        new
                        {
                            CountryId = 10,
                            CountryName = "Croatia"
                        },
                        new
                        {
                            CountryId = 11,
                            CountryName = "Cyprus"
                        },
                        new
                        {
                            CountryId = 12,
                            CountryName = "Czech Republic"
                        },
                        new
                        {
                            CountryId = 13,
                            CountryName = "Denmark"
                        },
                        new
                        {
                            CountryId = 14,
                            CountryName = "Estonia"
                        },
                        new
                        {
                            CountryId = 15,
                            CountryName = "Finland"
                        },
                        new
                        {
                            CountryId = 16,
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = 17,
                            CountryName = "Georgia"
                        },
                        new
                        {
                            CountryId = 18,
                            CountryName = "Germany"
                        },
                        new
                        {
                            CountryId = 19,
                            CountryName = "Greece"
                        },
                        new
                        {
                            CountryId = 20,
                            CountryName = "Hungary"
                        },
                        new
                        {
                            CountryId = 21,
                            CountryName = "Iceland"
                        },
                        new
                        {
                            CountryId = 22,
                            CountryName = "Ireland"
                        },
                        new
                        {
                            CountryId = 23,
                            CountryName = "Italy"
                        },
                        new
                        {
                            CountryId = 24,
                            CountryName = "Kazakhstan"
                        },
                        new
                        {
                            CountryId = 25,
                            CountryName = "Latvia"
                        },
                        new
                        {
                            CountryId = 26,
                            CountryName = "Liechtenstein"
                        },
                        new
                        {
                            CountryId = 27,
                            CountryName = "Lithuania"
                        },
                        new
                        {
                            CountryId = 28,
                            CountryName = "Luxembourg"
                        },
                        new
                        {
                            CountryId = 29,
                            CountryName = "Macedonia"
                        },
                        new
                        {
                            CountryId = 30,
                            CountryName = "Malta"
                        },
                        new
                        {
                            CountryId = 31,
                            CountryName = "Moldova"
                        },
                        new
                        {
                            CountryId = 32,
                            CountryName = "Monaco"
                        },
                        new
                        {
                            CountryId = 33,
                            CountryName = "Montenegro"
                        },
                        new
                        {
                            CountryId = 34,
                            CountryName = "Netherlands"
                        },
                        new
                        {
                            CountryId = 35,
                            CountryName = "Norway"
                        },
                        new
                        {
                            CountryId = 36,
                            CountryName = "Poland"
                        },
                        new
                        {
                            CountryId = 37,
                            CountryName = "Portugal"
                        },
                        new
                        {
                            CountryId = 38,
                            CountryName = "Romania"
                        },
                        new
                        {
                            CountryId = 39,
                            CountryName = "Russia"
                        },
                        new
                        {
                            CountryId = 40,
                            CountryName = "San Marino"
                        },
                        new
                        {
                            CountryId = 41,
                            CountryName = "Serbia"
                        },
                        new
                        {
                            CountryId = 42,
                            CountryName = "Slovakia"
                        },
                        new
                        {
                            CountryId = 43,
                            CountryName = "Slovenia"
                        },
                        new
                        {
                            CountryId = 44,
                            CountryName = "Spain"
                        },
                        new
                        {
                            CountryId = 45,
                            CountryName = "Sweden"
                        },
                        new
                        {
                            CountryId = 46,
                            CountryName = "Switzerland"
                        },
                        new
                        {
                            CountryId = 47,
                            CountryName = "Turkey"
                        },
                        new
                        {
                            CountryId = 48,
                            CountryName = "Ukraine"
                        },
                        new
                        {
                            CountryId = 49,
                            CountryName = "United Kingdom"
                        });
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("IndividualDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValueSql("0");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("CountryId");

                    b.HasIndex("UserId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("DiscountId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveredDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Statistic", b =>
                {
                    b.Property<int>("StatisticId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<short>("Rate")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("StatisticDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("StatisticId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Statistic");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.BasketItem", b =>
                {
                    b.HasOne("Codecool.OnlineStore.Model.Customer", "Customer")
                        .WithMany("Basket")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codecool.OnlineStore.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Customer", b =>
                {
                    b.HasOne("Codecool.OnlineStore.Model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codecool.OnlineStore.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Discount", b =>
                {
                    b.HasOne("Codecool.OnlineStore.Model.Product", "Product")
                        .WithOne("ActiveDiscount")
                        .HasForeignKey("Codecool.OnlineStore.Model.Discount", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Order", b =>
                {
                    b.HasOne("Codecool.OnlineStore.Model.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.OrderItem", b =>
                {
                    b.HasOne("Codecool.OnlineStore.Model.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codecool.OnlineStore.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Product", b =>
                {
                    b.HasOne("Codecool.OnlineStore.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Statistic", b =>
                {
                    b.HasOne("Codecool.OnlineStore.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codecool.OnlineStore.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Customer", b =>
                {
                    b.Navigation("Basket");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Codecool.OnlineStore.Model.Product", b =>
                {
                    b.Navigation("ActiveDiscount");
                });
#pragma warning restore 612, 618
        }
    }
}
