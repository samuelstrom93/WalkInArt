using DSU21_2.Data;
using DSU21_2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        #region Artist
        /// <summary>
        /// Lägger in nya konstnärer. ProfilId sköter Google.
        /// </summary>
        /// 
        public Artist AddArtist(string name, string about, string profileId)
        {
            var artist = new Artist { Name = name, About = about, ProfileId = profileId};
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }

        public async Task<Artist>GetArtistById(int id)
        {
            return await context.Artists
                .Include(a => a.Collections)
                .ThenInclude(b => b.Artworks)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Artist> GetArtistByProfileId(string profileId)
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
        /// <summary>
        /// Kollar om det är en befintlig konstnär eller ej.
        /// </summary>
        /// 
        public async Task<Artist>CheckArtist(string profileId, string name)
        {
            Artist artist = await GetArtistByProfileId(profileId);
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
        /// <summary>
        /// Hämtar alla utställningar som innerhåller konstverk.
        /// </summary>
        /// 
        public async Task<List<Collection>> GetCollectionsWithArt()
        {
            return await context.Collections
                .Include(x => x.Artworks)
                .Where(y => y.Artworks.Count > 0).ToListAsync();
        }
        /// <summary>
        /// Lägger till utställning utan en kategori.
        /// </summary>
        /// 
        public void AddCollection(Artist artist, string name, string description)
        {
            Collection collection = new Collection { Name = name, Description = description };
            artist.Collections.Add(collection);
            context.SaveChanges();
        }
        /// <summary>
        /// Lägger till utställning med en kategori.
        /// </summary>
        /// 
        public async Task AddCollection(Artist artist, string name, string description, string category)
        {
            Collection collection = new Collection { Name = name, Description = description };
            Tag tag = await AddTag(category);
            collection.Tags.Add(tag);
            artist.Collections.Add(collection);
            context.SaveChanges();
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

        public void AddArtwork(Collection collection, string name, string description, string hyperlink)
        {
            Artwork art = new Artwork { Name = name, Description = description, Hyperlink = hyperlink };
            collection.Artworks.Add(art);
            context.SaveChanges();
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
        /// <summary>
        /// Tag = Kategori.
        /// </summary>
        /// 
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

        public async Task<Tag> GetTagById(int tagId)
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
