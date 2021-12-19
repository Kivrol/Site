﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PShop.Data;

namespace PShop.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210928152216_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("PShop.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("PShop.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ItemId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PShop.Models.Review", b =>
                {
                    b.HasOne("PShop.Models.Item", "Item")
                        .WithMany("Reviews")
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("PShop.Models.Item", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
