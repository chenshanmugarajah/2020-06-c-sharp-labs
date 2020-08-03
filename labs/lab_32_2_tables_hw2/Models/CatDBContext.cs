using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lab_32_2_tables_hw2.Models
{
    public partial class CatDBContext : DbContext
    {
        public CatDBContext()
        {
        }

        public CatDBContext(DbContextOptions<CatDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Breeds> Breeds { get; set; }
        public virtual DbSet<Cats> Cats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb;Initial Catalog = CatDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Breeds>(entity =>
            {
                entity.HasKey(e => e.BreedId)
                    .HasName("PK__Breeds__D1E9AE9D0CE28398");

                entity.Property(e => e.BreedName).HasMaxLength(50);
            });

            modelBuilder.Entity<Cats>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Cats__6A1C8AFA3BC90741");

                entity.Property(e => e.CatName).HasMaxLength(50);

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.Cats)
                    .HasForeignKey(d => d.BreedId)
                    .HasConstraintName("FK__Cats__BreedId__25869641");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
