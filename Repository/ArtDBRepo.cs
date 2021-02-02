using DSU21_2.Data;
using DSU21_2.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Repository
{
    public class ArtDBRepo: IArtDBRepo
    {
        private readonly ArtContext context;

        public ArtDBRepo(ArtContext context)
        {
            this.context  =  context;
        }

        public async Task FillDbWithData() // Endast för att fylla DB med fejkdata.
        {
            string data = File.ReadAllText(@"Test_v2.json");
            var result = JsonConvert.DeserializeObject<List<Artist>>(data);
            foreach (var artist in result)
            {
                context.Artists.Add(artist);
            }
            //context.SaveChanges();

            var data2 = File.ReadAllText(@"testTag.json");
            var result2 = JsonConvert.DeserializeObject<List<Tag>>(data2);
            foreach (var tag in result2)
            {
                context.Tags.Add(tag);

            }
            context.SaveChanges();
            Random random = new Random();
            List<Tag> tags = await GetTags();
            List<Collection> collections = await GetCollectionsWithArt();
            foreach (var collection in collections)
            {
                collection.Tags.Add(tags[random.Next(8)]);
            }
            context.SaveChanges();
        }
        
        #region Artist

        public Artist AddArtist(string name, string about)
        {
            var artist = new Artist { Name = name, About = about };
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }

        public async Task<Artist>GetArtistAsync(int id)
        {
            return await context.Artists
                .Include(a => a.Collections)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Artist>UpdateArtist(int id, string about)
        {
            Artist artist = await GetArtistAsync(id);
            artist.About = about;
            context.Artists
                .Update(artist);
            
            context.SaveChanges();
            return artist;
        }
        #endregion

        #region Collection

        public async Task<Collection> GetCollection(int collectionId)
        {            
            return await context.Collections
                .Include(x => x.Artworks)
                .FirstOrDefaultAsync(y =>y.Id == collectionId);
        }
        
        public async Task<List<Collection>> GetCollectionsWithArt()
        {
            return await context.Collections
                .Include(x => x.Artworks)
                .Where(y => y.Artworks.Count > 0).ToListAsync();
        }

        public bool AddCollection(Artist artist)
        {
            Collection collection = new Collection { Name = "Sommar", Description = "Vårblommor i solen som aldrig skiner hos Espen" };
            artist.Collections.Add(collection);
            context.SaveChanges();
            return true;
        }

        public async Task<List<Collection>> GetCollectionWithTags()
        {
            return await context.Collections
                .Where(x => x.Tags.Count > 0).ToListAsync();
        }

       
        public async Task<List<Collection>> GetCollectionWithTag(int tagId)
        {
            Tag tag = await GetTag(tagId);
            return tag.Collections;
        }




        #endregion

        #region Artwork

        public bool AddArtwork(Collection collection)
        {
            Artwork art = new Artwork { Name = "Winter", Description = "This amazing winter shot", Hyperlink = "https://i.imgur.com/sxjAWXB.jpg" };
            collection.Artworks.Add(art);
            context.SaveChanges();
            return true;
        }

        public async Task<Artwork> GetArtwork(int artworkId)
        {
            return await context.Artworks
                .FirstOrDefaultAsync(x => x.Id ==  artworkId);            
        }

        #endregion

        #region Tag

        public bool AddTag(string title)
        {
            title = "Fotografi";
            var tag = new Tag { Title = title };
            context.Tags.Add(tag);
            context.SaveChanges();
            return true;
        }

        public async Task<List<Tag>> GetTags()
        {
            return await context.Tags
                 .Include(a => a.Collections)
                .ThenInclude(b => b.Artworks)
                .ToListAsync();

        }

        public async Task<Tag> GetTag(int tagId)
        {
            return await context.Tags
                .Include(a => a.Collections)
                .ThenInclude(b=> b.Artworks)
                .FirstOrDefaultAsync(x => x.Id == tagId);
        }



        #endregion



















    }
}
