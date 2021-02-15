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

        public Artist AddArtist(string name, string about, string profileId)
        {
            var artist = new Artist { Name = name, About = about, ProfileId = profileId};
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }

        public async Task<Artist>GetArtistAsync(int id)
        {
            return await context.Artists
                .Include(a => a.Collections)
                .ThenInclude(b => b.Artworks)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Artist> GetArtistByProfile(string profileId)
        {
            return await context.Artists
                .Include(a => a.Collections)
                .ThenInclude(b => b.Artworks)
                .FirstOrDefaultAsync(x => x.ProfileId == profileId);
        }
        public async Task<Artist> GetArtistByCollection(Collection collection)
        {
            return await context.Artists
                .Where(a => a.Collections.Contains(collection))
                .FirstOrDefaultAsync();
        }

        public Artist UpdateArtist(Artist artist, string about)
        {
            artist.About = about;
            context.Artists
                .Update(artist);
            
            context.SaveChanges();
            return artist;
        }

        public async Task<Artist>CheckArtist(string profileId, string name)
        {
            Artist artist = await GetArtistByProfile(profileId);
            if(artist != null)
                {
                return artist;
                }
            else
            {
                artist = AddArtist(name, "", profileId);

            }
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

        public bool AddCollection(Artist artist, string name, string description)
        {
            Collection collection = new Collection { Name = name, Description = description };
            artist.Collections.Add(collection);
            context.SaveChanges();
            return true;
        }

        public async Task <bool>AddCollection(Artist artist, string name, string description, string category)
        {
            Collection collection = new Collection { Name = name, Description = description };
            Tag tag = await AddTag(category);
            collection.Tags.Add(tag);
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

        public async Task<Collection> UpdateCollection(int id, string description, string name)
        {
            Collection collection = await GetCollection(id);
            collection.Description = description;
            collection.Name = name;
            context.Collections
                .Update(collection);

            context.SaveChanges();
            return collection;
        }

        public void DeleteCollection(Collection collection)
        {
            foreach(Artwork artwork in collection.Artworks)
            {
                context.Artworks.Remove(artwork);
            }
            context.Collections.Remove(collection);
            context.SaveChanges();
        }


        #endregion

        #region Artwork

        public bool AddArtwork(Collection collection, string name, string description, string hyperlink)
        {
            Artwork art = new Artwork { Name = name, Description = description, Hyperlink = hyperlink };
            collection.Artworks.Add(art);
            context.SaveChanges();
            return true;
        }

        public async Task<Artwork> GetArtwork(int artworkId)
        {
            return await context.Artworks
                .FirstOrDefaultAsync(x => x.Id ==  artworkId);            
        }

        public void DeleteArtwork(Artwork artwork)
        {
            context.Artworks.Remove(artwork);
            context.SaveChanges();
        }


        public async Task<Artwork> UpdateArtwork(int id, string hyperlink, string description, string name)
        {
            Artwork artwork = await GetArtwork(id);
            artwork.Description = description;
            artwork.Hyperlink = hyperlink;
            artwork.Name = name;
            context.Artworks
                .Update(artwork);

            context.SaveChanges();
            return artwork;
        }

        #endregion

        #region Tag

        public async Task<Tag> AddTag(string title)
        {
            Tag tag;
            tag = await context.Tags
                .FirstOrDefaultAsync(a => a.Title == title);

            if(tag == null)
            {
                tag = new Tag();
                tag.Title = title;
                context.Tags.Add(tag);
                context.SaveChanges();
            }
            return tag;
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

        public async Task<Tag> GetTagByName(string title)
        {
            return await context.Tags
                .Include(a => a.Collections)
                .ThenInclude(b => b.Artworks)
                .FirstOrDefaultAsync(x => x.Title == title);
        }



        #endregion



















    }
}
