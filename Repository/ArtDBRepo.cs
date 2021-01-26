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
        }

        public Artist AddArtist(string name, string about)
        {
            var artist = new Artist { Name = name, About = about };
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }

        public Artist AddCollection(string name, string about)
        {
            var artist = new Artist { Name = name, About = about };
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }


















    }
}
