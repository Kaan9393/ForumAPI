using ForumAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Data
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<SubCategory>()
                .HasOne<Category>()
                .WithMany()
                .HasForeignKey(c => c.CategoryId);


            builder.Entity<Post>()
                .HasOne<SubCategory>()
                .WithMany()
                .HasForeignKey(c => c.SubCategoryId);

            builder.Entity<Comment>()
                .HasOne<Post>()
                .WithMany()
                .HasForeignKey(c => c.PostId);
        }
    }
}


