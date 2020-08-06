using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lab_35_library_api.Models
{
    public partial class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {
        }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BoroughLibrarys> BoroughLibrarys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb;Initial Catalog = LibraryDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__Books__3DE0C2077C61208F");

                entity.Property(e => e.BookAuthor).HasMaxLength(50);

                entity.Property(e => e.BookTitle).HasMaxLength(50);

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.LibraryId)
                    .HasConstraintName("FK__Books__LibraryId__25869641");
            });

            modelBuilder.Entity<BoroughLibrarys>(entity =>
            {
                entity.HasKey(e => e.LibraryId)
                    .HasName("PK__BoroughL__A136475F9ADC7A95");

                entity.Property(e => e.LibraryName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
