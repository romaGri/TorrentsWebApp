using System;
using Microsoft.EntityFrameworkCore;
using TorrentsWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TorrentsWebApp.Models

{
    public partial class torrentsdbContext : DbContext
    {
        public torrentsdbContext()
        {
        }

        public torrentsdbContext(DbContextOptions<torrentsdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Forums> Forums { get; set; }
        public virtual DbSet<Torrents> Torrents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=torrentsdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Files>(entity =>
            {
                entity.HasIndex(e => e.TorrentId);

                entity.HasOne(d => d.Torrent)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.TorrentId);
            });

            modelBuilder.Entity<Torrents>(entity =>
            {
                entity.HasIndex(e => e.ForumId);

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.Torrents)
                    .HasForeignKey(d => d.ForumId);
            });
        }
    }
}
