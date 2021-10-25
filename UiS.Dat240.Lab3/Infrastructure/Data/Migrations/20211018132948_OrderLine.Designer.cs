﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UiS.Dat240.Lab3.Infrastructure.Data;

namespace UiS.Dat240.Lab3.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20211018132948_OrderLine")]
    partial class OrderLine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Cart.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ShoppingCartId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sku")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Cart.ShoppingCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Ordering.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Ordering.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Ordering.OrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLine");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Products.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CookTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Cart.CartItem", b =>
                {
                    b.HasOne("UiS.Dat240.Lab3.Core.Domain.Cart.ShoppingCart", null)
                        .WithMany("Items")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Ordering.Order", b =>
                {
                    b.HasOne("UiS.Dat240.Lab3.Core.Domain.Ordering.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.OwnsOne("UiS.Dat240.Lab3.Core.Domain.Ordering.Location", "Location", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Building")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Notes")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<int>("RoomNumber")
                                .HasColumnType("INTEGER");

                            b1.HasKey("OrderId");

                            b1.ToTable("Order");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Ordering.OrderLine", b =>
                {
                    b.HasOne("UiS.Dat240.Lab3.Core.Domain.Ordering.Order", null)
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Cart.ShoppingCart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("UiS.Dat240.Lab3.Core.Domain.Ordering.Order", b =>
                {
                    b.Navigation("OrderLines");
                });
#pragma warning restore 612, 618
        }
    }
}
