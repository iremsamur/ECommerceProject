using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-ISO96UVH\\SQLEXPRESS;database=ECommerceCapstoneProjectDB;integrated security=true;");


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MindList>()
         .HasKey(pt => new { pt.ItemId, pt.UserId });
            builder.Entity<MindList>().HasOne(pt => pt.Item)
                .WithMany(p => p.MindLists)
                .HasForeignKey(pt => pt.ItemId);
            builder.Entity<MindList>().HasOne(pt => pt.AppUser)
                .WithMany(p => p.MindLists)
                .HasForeignKey(pt => pt.UserId);
            base.OnModelCreating(builder);

            //AdItem
            builder.Entity<AdItems>()
         .HasKey(pt => new { pt.ItemId, pt.IndividualSellerId,pt.CompanySellerId });
            builder.Entity<AdItems>().HasOne(pt => pt.Item)
                .WithMany(p => p.AdItemss)
                .HasForeignKey(pt => pt.ItemId);
            builder.Entity<AdItems>().HasOne(pt => pt.CompanySeller)
                .WithMany(p => p.AdItems)
                .HasForeignKey(pt => pt.CompanySellerId);
            builder.Entity<AdItems>().HasOne(pt => pt.IndividualSeller)
              .WithMany(p => p.AdItems)
              .HasForeignKey(pt => pt.IndividualSellerId);
            base.OnModelCreating(builder);
        }




        public DbSet<Item> Items { get; set; }
        public DbSet<ItemDetail> ItemDetails { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<ItemDiscountScore> ItemDiscountScores { get; set; }
        public DbSet<ItemRatings> ItemRatings { get; set; }
        public DbSet<ItemRatingsSpModel> ItemRatingsSpModels { get; set; }
        public DbSet<ItemDiscountScoresSpModel> ItemDiscountScoresSpModels { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<MindList> MindLists { get; set; }
        public DbSet<IndividualSeller> IndividualSellers { get; set; }
        public DbSet<CompanySeller> CompanySellers { get; set; }
        public DbSet<AdItems> AdItemss { get; set; }
    }
}
