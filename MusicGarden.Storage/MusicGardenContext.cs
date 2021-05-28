using System;
using Microsoft.EntityFrameworkCore;
using MusicGarden.Domain.Models;

namespace MusicGarden.Storage
{
  public class MusicGardenContext : DbContext
  {
    public DbSet<SavingTrack> Tracks { get; set; }
    //public DbSet<User> Users { get; set; }
    public DbSet<SavingPlaylist> Playlists { get; set; }

    public MusicGardenContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<SavingPlaylist>().HasKey(e => e.id);
      builder.Entity<SavingTrack>().HasKey(e => e.id);
      //builder.Entity<User>().HasKey(e => e.id);

      //   builder.Entity<Playlist>().HasMany<Track>(p => p.tracks).WithMany(t => t.playlists);
      //   builder.Entity<User>().HasMany<Playlist>(u => u.playlists);

      //OnModelSeeding(builder);
    }

    private static void OnModelSeeding(ModelBuilder builder)
    {
      //   builder.Entity<User>().HasData(new User[] {
      //             new User() {id = "0001", name = "Just Monika", lastname = "Just", firstname = "Monika", email = "teamSalvato@gmail.com", status = 1, birthday = new DateTime(2017, 9, 22), inscription_date = new DateTime(2021, 5, 26), gender = "F", link = "", picture = "url", picture_small = "url_small", picture_medium = "url_medium", picture_big = "url_big", picture_xl = "url_xl", country = "United States", lang = "English", is_kid = false, explicit_content_level = "explicit_display", tracklist = "url_api"}
      //         });
    }
  }
}