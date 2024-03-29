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
    [Migration("20230122163844_mig_initial_create_tables")]
    partial class mig_initial_create_tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

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

                    b.Property<string>("ItemSubShowcaseImage")
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

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromWho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemAdType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ItemAnnouncementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemDetailDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemDiscount")
                        .HasColumnType("float");

                    b.Property<double>("ItemNewPrice")
                        .HasColumnType("float");

                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemOldPrice")
                        .HasColumnType("float");

                    b.Property<string>("ItemStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("gGuarantee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("ItemDetailID");

                    b.HasIndex("BrandID");

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

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemDiscountScoresSpModel", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemDiscount")
                        .HasColumnType("float");

                    b.Property<int>("ItemDiscountScoreID")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemNewPrice")
                        .HasColumnType("float");

                    b.Property<double>("ItemOldPrice")
                        .HasColumnType("float");

                    b.Property<string>("ItemShowcaseImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemTotalDiscountScore")
                        .HasColumnType("float");

                    b.HasKey("ItemID");

                    b.ToTable("ItemDiscountScoresSpModels");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.ItemDetail", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.Brand", "Brand")
                        .WithMany("ItemDetails")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ECommerce.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.EntityLayer.Concrete.Brand", b =>
                {
                    b.Navigation("ItemDetails");
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
