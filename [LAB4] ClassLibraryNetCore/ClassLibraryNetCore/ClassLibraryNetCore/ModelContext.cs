using ClassLibraryNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
namespace ClassLibraryNetCore.Model
{
    public class ModelContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RVIDM7O\\SQLEXPRESS;Initial Catalog=EfCore2020;Integrated Security=True");
       
 }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumArtist>()
                  .HasKey(obj => new { obj.AlbumId, obj.ArtistId });

            modelBuilder.Entity<AlbumArtist>()
                .HasOne(obj => obj.Artist)
                .WithMany(obj => obj.AlbumArtists)
                .HasForeignKey(obj => obj.ArtistId);

            modelBuilder.Entity<AlbumArtist>()
                .HasOne(obj => obj.Album)
                .WithMany(obj => obj.AlbumArtists)
                .HasForeignKey(obj => obj.AlbumId);
        }
    }
}