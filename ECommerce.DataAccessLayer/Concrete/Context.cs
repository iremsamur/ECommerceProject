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
       


            builder.Entity<ItemOwner>()
        .HasKey(pt => new { pt.OwnerId, pt.ItemAdId });
            builder.Entity<ItemOwner>().HasOne(pt => pt.ItemAd)
                .WithMany(p => p.ItemOwners)
                .HasForeignKey(pt => pt.ItemAdId);
            builder.Entity<ItemOwner>().HasOne(pt => pt.OwnerUser)
                .WithMany(p => p.ItemOwners)
                .HasForeignKey(pt => pt.OwnerId);


            builder.Entity<ItemDetailOwner>()
        .HasKey(pt => new { pt.OwnerId, pt.ItemDetailId });
            builder.Entity<ItemDetailOwner>().HasOne(pt => pt.ItemAdDetail)
                .WithMany(p => p.ItemDetailOwners)
                .HasForeignKey(pt => pt.ItemDetailId);
            builder.Entity<ItemDetailOwner>().HasOne(pt => pt.OwnerUser)
                .WithMany(p => p.ItemDetailOwners)
                .HasForeignKey(pt => pt.OwnerId);



            builder.Entity<Message>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.UserSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);
         
            builder.Entity<Message>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.UserReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);

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
        //public DbSet<AdItems> AdItemss { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ItemOwner> ItemOwners { get; set; }

        public DbSet<ItemDetailOwner> ItemDetailOwners { get; set; }
    }
}
