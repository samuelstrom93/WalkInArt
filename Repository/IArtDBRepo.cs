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
        Task<Collection> GetCollection(int collectionId);
        Artist AddArtist(string name, string about);
        bool AddCollection(Artist artist);
        bool AddArtwork(Collection collection);
        Task<List<Collection>> GetCollectionsWithArt();
        bool AddTag(string title);
        Task<List<Tag>> GetTags();
        Task<Artist> UpdateArtist(int id, string about);
        Task<List<Collection>> GetCollectionWithTag(int tagId);
        Task<Artwork> GetArtwork(int artworkId);
        void FillDbWithData();

    }
}
