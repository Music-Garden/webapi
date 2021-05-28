﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicGarden.Storage;

namespace MusicGarden.Storage.Migrations
{
    [DbContext(typeof(MusicGardenContext))]
    [Migration("20210528055352_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicGarden.Domain.Models.SavingPlaylist", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("playlistname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("unique_ID")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("MusicGarden.Domain.Models.SavingTrack", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SavingPlaylistid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("trackname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("unique_ID")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("SavingPlaylistid");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("MusicGarden.Domain.Models.SavingTrack", b =>
                {
                    b.HasOne("MusicGarden.Domain.Models.SavingPlaylist", null)
                        .WithMany("Tracks")
                        .HasForeignKey("SavingPlaylistid");
                });

            modelBuilder.Entity("MusicGarden.Domain.Models.SavingPlaylist", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}