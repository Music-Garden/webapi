using System;
using System.Collections.Generic;
using MusicGarden.Domain.Models;
using Xunit;

namespace MusicGarden.Testing
{
    public class AlbumTest
    {
        [Fact]
        public void NewAlbum()
        {
            var tester = new Album();
            Assert.NotNull(tester);
        }
        [Theory]
        [InlineData("01", 1)]
        [InlineData("02", 2)]
        public void NewAlbumIDs(string ID, long id)
        {
            var tester = new Album();
            tester.id = ID;
            tester.uniqueID = id;

            Assert.NotNull(tester.id);
            Assert.NotNull(tester.uniqueID);
        }
        [Theory]
        [InlineData("Your Reality")]
        [InlineData("The Tragedy")]
        public void NewAlbumTitle(string newTitle)
        {
            var tester = new Album();
            tester.title = newTitle;

            Assert.NotNull(tester.title);
        }
        [Theory]
        [InlineData("012345678910", "https://www.helloworld.com", "https://www.helloworld.com/share")]
        [InlineData("987654321069", "http://www.darthplageius.com", "http://www.darthplageius.com/share")]
        public void NewAlbumLinkage(string newUPC, string newLink, string newShare)
        {
            var tester = new Album();
            tester.upc = newUPC;
            tester.link = newLink;
            tester.share = newShare;

            Assert.True(tester.upc.Length == 12);
            Assert.True(tester.link[5] == ':' || tester.link[4] == ':');
            Assert.NotNull(tester.upc);
        }
        [Theory]
        [InlineData("normal", "small", "medium", "large", "xl")]
        public void NewAlbumCovers(string nc, string ncs, string ncm, string ncb, string ncx)
        {
            var tester = new Album();
            tester.cover = nc;
            tester.cover_small = ncs;
            tester.cover_medium = ncm;
            tester.cover_big = ncb;
            tester.cover_xl = ncx;

            Assert.NotNull(tester.cover);
            Assert.NotNull(tester.cover_small);
            Assert.NotNull(tester.cover_medium);
            Assert.NotNull(tester.cover_big);
            Assert.NotNull(tester.cover_xl);
        }
        [Theory]
        [InlineData(1)]
        public void NewAlbumGenres(int newgenreID)
        {
            var tester = new Album();
            var gen = new Genre();
            tester.genre_id = newgenreID;
            tester.genres.genre.Add(gen);

            Assert.True(tester.genre_id <= 0);
            Assert.True(tester.genres.genre.Count != 0);
        }
        [Theory]
        [InlineData("Mon")]
        [InlineData("Tun")]
        public void NewAlbumLabel(string newLab)
        {
            var tester = new Album();
            tester.label = newLab;

            Assert.NotNull(tester.label);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void NewAlbumnbTrack(int newNB)
        {
            var tester = new Album();
            tester.nb_tracks = newNB;

            Assert.NotNull(tester.nb_tracks);
        }
        [Theory]
        [InlineData(300)]
        [InlineData(360)]
        public void NewAlbumDuration(int newDuration)
        {
            var tester = new Album();
            tester.duration = newDuration;

            Assert.NotNull(tester.duration);
        }
        [Theory]
        [InlineData(9000)]
        [InlineData(42000)]
        public void NewAlbumFans(int newFans)
        {
            var tester = new Album();
            tester.fans = newFans;

            Assert.NotNull(tester.fans);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(4)]
        public void NewAlbumRating(int newRating)
        {
            var tester = new Album();
            tester.rating = newRating;

            Assert.NotNull(tester.rating);
        }
        [Theory]
        [InlineData("3 - 29 - 20")]
        [InlineData("4 - 20 - 69")]
        public void NewAlbumRelease(string newDate)
        {
            var tester = new Album();
            tester.release_date = newDate;

            Assert.NotNull(tester.release_date);
        }
        [Theory]
        [InlineData("Vinyl")]
        [InlineData("MP3")]
        public void NewAlbumRecord(string newRecord)
        {
            var tester = new Album();
            tester.record_type = newRecord;

            Assert.NotNull(tester.record_type);
        }
        [Fact]
        public void NewAlbumAvailable()
        {
            var tester = new Album();
            tester.available = true;

            Assert.True(tester.available);
        }
        [Theory]
        [InlineData("Boom, Koom, Moom")]
        [InlineData("Love, Hugs, Kisses")]
        public void NewAlbumTracklist(string newTL)
        {
            var tester = new Album();
            tester.tracklist = newTL;

            Assert.NotNull(tester.tracklist);
        }
        [Fact]
        public void NewAlbumExplicitLyric()
        {
            var tester = new Album();
            tester.explicit_lyrics = true;

            Assert.True(tester.explicit_lyrics);
        }
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void NewAlbumExplicitConLyr(int newConLyr)
        {
            var tester = new Album();
            tester.explicit_content_lyrics = newConLyr;

            Assert.NotNull(tester.explicit_content_lyrics);
        }
        [Theory]
        [InlineData(4)]
        [InlineData(1)]
        public void NewAlbumExplicitConCov(int newConCov)
        {
            var tester = new Album();
            tester.explicit_content_cover = newConCov;

            Assert.NotNull(tester.explicit_content_cover);
        }
        [Theory]
        [InlineData("Dan Salvato")]
        [InlineData("Darth Plageius")]
        public void NewAlbumContributors(string newContributor)
        {
            var tester = new Album();
            Contributor newCon = new Contributor();
            newCon.name = newContributor;
            tester.contributors.Add(newCon);

            Assert.True(tester.contributors.Count <= 0);
        }
        [Theory]
        [InlineData("Just Monika")]
        [InlineData("Mario Jumpman Mario")]
        public void NewAlbumArtist(string newArtist)
        {
            var tester = new Album();
            Artist newArt = new Artist();
            newArt.name = newArtist;
            tester.artist = newArt;

            Assert.NotNull(tester.artist);
            Assert.NotNull(tester.artist.name);
        }
        [Theory]
        [InlineData("Hello")]
        [InlineData("World")]
        public void NewAlbumType(string newType)
        {
            var tester = new Album();
            tester.type = newType;

            Assert.NotNull(tester.type);
        }
        [Theory]
        [InlineData("The Entirety of the Bee Movie")]
        [InlineData("Your Reality")]
        public void NewAlbumTracks(string newTracks)
        {
            var tester = new Album();
            RootTrack newRoot = new RootTrack();
            Track newTrack = new Track();
            newTrack.title = newTracks;
            newRoot.data.Add(newTrack);
            tester.tracks = newRoot;

            Assert.NotNull(tester.tracks);
        }

    }
}