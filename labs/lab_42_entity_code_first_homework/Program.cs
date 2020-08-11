using lab_42_entity_code_first_homework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_42_entity_code_first_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RecordLabel> RecordLabels = new List<RecordLabel>();
            List<Song> Songs = new List<Song>();

            using (var db = new IndustryDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                RecordLabels = db.RecordLabels.Include("Songs").ToList();
                Songs = db.Songs.Include("RecordLabel").ToList();

                RecordLabels.ForEach(label => Console.WriteLine(label.RecordLabelName));
                Songs.ForEach(song => Console.WriteLine($"{song.SongName} by {song.SongArtist}"));

            }
        }
    }
}
