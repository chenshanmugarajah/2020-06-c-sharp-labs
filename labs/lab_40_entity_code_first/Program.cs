using lab_40_entity_code_first.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_40_entity_code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            List<Category> categories = new List<Category>();

            using (var db = new UserDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                //users = db.Users.ToList();
                //users.ForEach(user => Console.WriteLine($"User id: {user.UserId} {user.Username} was born {user.DateOfBirth}"));

                //User user = new User()
                //{
                //    Username = "some user"
                //};

                //db.Users.Add(user);
                //db.SaveChanges();

                users = db.Users.Include("Category").ToList();

                users.ForEach(user => Console.WriteLine($"User id: {user.UserId} {user.Username} was born {user.DateOfBirth} with category {user.Category.CategoryName}"));

                categories = db.Categories.ToList();
                categories.ForEach(category => Console.WriteLine($"Category id: {category.CategoryId} {category.CategoryName}"));

            }
        }
    }
}
