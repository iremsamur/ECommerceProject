using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
