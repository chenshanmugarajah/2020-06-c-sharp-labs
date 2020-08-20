using Microsoft.CodeAnalysis.Emit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_49_to_do_demo.Models
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }
        public ToDoDbContext()
        {
                
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // relationships
            // one user has many todos
            builder.Entity<User>()
                .HasMany(user => user.ToDos)
                .WithOne(user => user.User);
            // username is required
            builder.Entity<User>()
                .Property(user => user.UserName)
                .IsRequired();

            // seed data
            builder.Entity<User>().HasData(

                new User { UserId = 1, UserName = "Bob" },
                new User { UserId = 2, UserName = "Jim" },
                new User { UserId = 3, UserName = "Fred" }
            );

            builder.Entity<ToDo>().HasData(

                new ToDo { ToDoId = 1, ToDoName = "Start project!", UserId = 1 },
                new ToDo { ToDoId = 2, ToDoName = "Do something useful" },
                new ToDo { ToDoId = 3, ToDoName = "Buy milk" }
            );

        }
    }
}
