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
        Task<Artist> GetArtistByCollection(Collection collection);
        Task<Collection> GetCollection(int collectionId);
        void DeleteCollection(Collection collection);
        Artist AddArtist(string name, string about, string profileId);
        bool AddCollection(Artist artist, string name, string description);
        Task<bool> AddCollection(Artist artist, string name, string description, string category);
        bool AddArtwork(Collection collection, string name, string description, string hyperlink);
        Task<Artwork> UpdateArtwork(int id, string hyperlink, string description, string name);
        Task<List<Collection>> GetCollectionsWithArt();
        Task<Tag> AddTag(string title);
        Task<List<Tag>> GetTags();
        Task<Tag> GetTag(int tagId);
        Artist UpdateArtist(Artist artist, string about);
        Task<List<Collection>> GetCollectionWithTag(int tagId);
        Task<Artwork> GetArtwork(int artworkId);
        void DeleteArtwork(Artwork artwork);
        Task FillDbWithData();
        Task<Tag> GetTagByName(string title);
        Task<Artist> GetArtistByProfile(string profileId);
        Task<Artist> CheckArtist(string profileId, string name);
    }
}
