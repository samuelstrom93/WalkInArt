using DSU21_2.Data;
using DSU21_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<Artist>GetArtistAsync(int id)
        {
            return await context.Artists
                .Include(a => a.Collections)
                .FirstOrDefaultAsync(x => x.Id == id);
        }



        public async Task<List<Artist>> GetArtistsWithArt()
        {
            await Task.Delay(0);
            return null;
        }

        public async Task<Collection> GetCollection(int id)
        {
            await Task.Delay(0);
            return null;
        //    artist.Collections.Add(await context.Collections.All(x=> x. )
        }

        public Artist AddArtist(string name, string about)
        {
            var artist = new Artist { Name = name, About = about };
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }

        public bool AddCollection(Artist artist)
        {
            Collection collection = new Collection { Name = "Sommar", Description = "Vårblommor i solen som aldrig skiner hos Espen" };
            artist.Collections.Add(collection);
            context.SaveChanges();
            return true;
        }

       public bool AddArtwork(Collection collection)
        {
            Artwork art = new Artwork { Name = "Winter", Description = "This amazing winter shot", Hyperlink = "https://i.imgur.com/sxjAWXB.jpg" };
            collection.Artworks.Add(art);
            context.SaveChanges();
            return true;
        }
            
            
            //public Collection AddCollection(int artistId, string name, string description)
        //{
        //    var collection = new Collection {ArtistId = artistId, Name = name, Description = description };
        //    context.Collections.Add(collection);
        //    context.SaveChanges();
        //    return collection;
        //}

        //public Artwork AddArtwork(int artistId, string name, string description)
        //{
        //    var artWork = new Artwork { Name = name, Description = description };
        //    context.Artwork.Add(artWork);
        //    context.SaveChanges();
        //    return artWork;
        //}

















    }
}
