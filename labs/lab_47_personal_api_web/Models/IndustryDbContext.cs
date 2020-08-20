using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_47_personal_api_web.Models
{
    public class IndustryDbContext : DbContext
    {
        public IndustryDbContext(DbContextOptions<IndustryDbContext> options) : base(options) { }
        public DbSet<RecordLabel> RecordLabels { get; set; }
        public DbSet<Song> Songs { get; set; }

        public IndustryDbContext()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    //builder.UseSqlite("Data Source = MusicIndustry.db");
        //    builder.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb; initial catalog = MusicIndustryV2");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Song>(item => { item.Property(myclass => myclass.SongId).IsRequired(); });
            builder.Entity<RecordLabel>(item => { item.Property(myclass => myclass.RecordLabelId).IsRequired(); });

            builder.Entity<RecordLabel>().HasData(new RecordLabel { RecordLabelId = 1, RecordLabelName = "Sony", FoundedDate = new DateTime(1999, 05, 10) });
            builder.Entity<RecordLabel>().HasData(new RecordLabel { RecordLabelId = 2, RecordLabelName = "Universal", FoundedDate = new DateTime(1970, 12, 10) });
            builder.Entity<RecordLabel>().HasData(new RecordLabel { RecordLabelId = 3, RecordLabelName = "OvoSounds", FoundedDate = new DateTime(2010, 07, 12) });

            builder.Entity<Song>().HasData(new Song { SongId = 1, SongName = "Shape of You", SongArtist = "Ed Sheeran", SongSales = 14, RecordLabelId = 1 });
            builder.Entity<Song>().HasData(new Song { SongId = 2, SongName = "Place We Are Made", SongArtist = "Maisie Peters", SongSales = 2, RecordLabelId = 2 });
            builder.Entity<Song>().HasData(new Song { SongId = 3, SongName = "Toosie Slide", SongArtist = "Drake", SongSales = 10, RecordLabelId = 3 });
        }
    }
}
