using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using lab_48_mvc_web_demo.Models;

namespace lab_48_mvc_web_demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<lab_48_mvc_web_demo.Models.College> College { get; set; }
        public DbSet<lab_48_mvc_web_demo.Models.Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<College>()
            //    .HasKey(college => college.CollegeId);

            builder.Entity<College>()
                .Property(college => college.CollegeName)
                .IsRequired();
        }
    }
}
