// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PShop.Data;

namespace PShop.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20211218094929_aboba12487")]
    partial class aboba12487
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("PShop.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<long>("AvgScore")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Characteristics")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img5")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<decimal>("Sale")
                        .HasColumnType("TEXT");

                    b.Property<long>("ScoreCount")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ScoreSumm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("PShop.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Userid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.Property<string>("items")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PShop.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PShop.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("tag")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PShop.Models.Item", b =>
                {
                    b.HasOne("PShop.Models.Order", null)
                        .WithMany("Itemlist")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("PShop.Models.Review", b =>
                {
                    b.HasOne("PShop.Models.Item", "Item")
                        .WithMany("Reviews")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("PShop.Models.Item", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PShop.Models.Order", b =>
                {
                    b.Navigation("Itemlist");
                });
#pragma warning restore 612, 618
        }
    }
}
