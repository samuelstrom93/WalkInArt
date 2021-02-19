using DSU21_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Repository
{
    public interface IArtDBRepo
    {
        #region Artist
        Artist AddArtist(string name, string about, string profileId);
        Task<Artist> GetArtistById(int id);
        Task<Artist> GetArtistByCollection(Collection collection);
        Task<Artist> GetArtistByProfileId(string profileId);
        Task<Artist> CheckArtist(string profileId, string name);
        Artist UpdateArtist(Artist artist, string about);
        #endregion
        #region Collection
        void AddCollection(Artist artist, string name, string description);
        Task AddCollection(Artist artist, string name, string description, string category);
        Task<Collection> GetCollection(int collectionId);
        Task<List<Collection>> GetCollectionsWithArt();
        void DeleteCollection(Collection collection);
        #endregion
        #region Artwork
        void AddArtwork(Collection collection, string name, string description, string hyperlink);
        Task<Artwork> GetArtwork(int artworkId);
        Task<Artwork> UpdateArtwork(int id, string hyperlink, string description, string name);
        void DeleteArtwork(Artwork artwork);
        #endregion
        #region Tag
        Task<Tag> AddTag(string title);
        Task<List<Tag>> GetTags();
        Task<Tag> GetTagById(int tagId);
        Task<Tag> GetTagByName(string title);
        #endregion
    }
}
