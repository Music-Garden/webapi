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


    }
}