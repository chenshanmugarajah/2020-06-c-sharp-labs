using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_40_entity_code_first.Models
{
    class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // builder.UseSqlite("Data Source = UserDatabase.db");
            builder.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb; initial catalog = UserDatabase");
        }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Admin" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Database" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Standard" });

            builder.Entity<User>().HasData(new User { UserId = 1, Username = "Some user", DateOfBirth = new DateTime(2020, 07, 10), CategoryId = 1 });
            builder.Entity<User>().HasData(new User { UserId = 2, Username = "Special user", DateOfBirth = new DateTime(2020, 08, 10), CategoryId = 2 });
            builder.Entity<User>().HasData(new User { UserId = 3, Username = "Nobody user", DateOfBirth = new DateTime(2020, 01, 10), CategoryId = 3});
            
        }
    }
}
