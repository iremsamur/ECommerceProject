﻿// <auto-generated />
using System;
using ECommerce.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221127100008_mig_item_ratings_sp_model_added")]
    partial class mig_item_ratings_sp_model_added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemDetailID")
                        .HasColumnType("int");

                    b.Property<int>("ItemImageID")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemShowcaseImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("ItemID");

                    b.HasIndex("ItemDetailID");

                    b.HasIndex("ItemImageID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemDetail", b =>
                {
                    b.Property<int>("ItemDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ItemAnnouncementDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ItemDiscount")
                        .HasColumnType("float");

                    b.Property<double>("ItemNewPrice")
                        .HasColumnType("float");

                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemOldPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("ItemDetailID");

                    b.ToTable("ItemDetails");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemDiscountScore", b =>
                {
                    b.Property<int>("ItemDiscountScoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<double>("ItemTotalDiscountScore")
                        .HasColumnType("float");

                    b.HasKey("ItemDiscountScoreID");

                    b.ToTable("ItemDiscountScores");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemImage", b =>
                {
                    b.Property<int>("ItemImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("ItemImageID");

                    b.ToTable("ItemImages");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemRatings", b =>
                {
                    b.Property<int>("ItemRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("ItemRatingCount")
                        .HasColumnType("int");

                    b.Property<int>("ItemTotalRatingScore")
                        .HasColumnType("int");

                    b.HasKey("ItemRatingID");

                    b.HasIndex("ItemID");

                    b.ToTable("ItemRatings");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemRatingsSpModel", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemRatingID")
                        .HasColumnType("int");

                    b.Property<string>("ItemShowcaseImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemTotalRatingScore")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.ToTable("ItemRatingsSpModels");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.Item", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.ItemDetail", "ItemDetail")
                        .WithMany("Items")
                        .HasForeignKey("ItemDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.EntityLayer.Concrete.ItemImage", "ItemImage")
                        .WithMany("Items")
                        .HasForeignKey("ItemImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.EntityLayer.Concrete.SubCategory", "SubCategory")
                        .WithMany("Items")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemDetail");

                    b.Navigation("ItemImage");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemRatings", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.SubCategory", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemDetail", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemImage", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.SubCategory", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
