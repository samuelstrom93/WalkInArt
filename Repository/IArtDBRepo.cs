using DSU21_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Repository
{
    public interface IArtDBRepo
    {

        Task<Artist> GetArtistAsync(int id);
        Task<List<Artist>> GetArtistsWithArt();
        Task<Collection> GetCollection(int id);
        Artist AddArtist(string name, string about);
        bool AddCollection(Artist artist);
        bool AddArtwork(Collection collection);
    }
}
