using DSU21_2.Models;
using DSU21_2.Repository;
using DSU21_2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

/// <summary>
///  För att utställaren ska kunna hantera sin konstverk efter inloggning
/// </summary>
/// 

namespace DSU21_2.Controllers
{
    [Authorize]
    public class ArtistProfileController : Controller
    {
        private readonly IArtDBRepo artDbRepo;
        public ArtistProfileController(IArtDBRepo artDbRepo)
        {
            this.artDbRepo = artDbRepo;
        }


        public async Task<IActionResult> Index(string profileId, string profileFirstName)
        {
            Artist artist = await artDbRepo.CheckArtist(profileId, profileFirstName);
            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View(viewModel);
        }

        //CRUD för utsällningar och konstverk
        public async Task<IActionResult> AddCollection(string title, string description, int id, string category)
        {
            Artist artist = await artDbRepo.GetArtistById(id);

            if (String.IsNullOrEmpty(category))
            {
                artDbRepo.AddCollection(artist, title, description);
            }
            else
            {
                await artDbRepo.AddCollection(artist, title, description, category);
            }


            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View("Index", viewModel);
        }

        public async Task<IActionResult> AddArtwork(string title, string description, string url, int artistId, int collectionId)
        {
            Collection collection = await artDbRepo.GetCollection(collectionId);
            artDbRepo.AddArtwork(collection,title,description,url);


            Artist artist = await artDbRepo.GetArtistById(artistId);
            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View("Index", viewModel);
        }

        public async Task<IActionResult> UpdateArtwork(string title, string description, string url, int artistId, int artworkId)
        {
            await artDbRepo.UpdateArtwork( artworkId, url, description, title);
            
            Artist artist = await artDbRepo.GetArtistById(artistId);
            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View("Index", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveArtwork(int artworkId, int artistId)
        {
            Artwork art = await artDbRepo.GetArtwork(artworkId);
            artDbRepo.DeleteArtwork(art);

            Artist artist = await artDbRepo.GetArtistById(artistId);
            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View("Index", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveCollection(int collectionId, int artistId)
        {
            Collection collection = await artDbRepo.GetCollection(collectionId);
            artDbRepo.DeleteCollection(collection);

            Artist artist = await artDbRepo.GetArtistById(artistId);
            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View("Index", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateArtist(int artistId, string about)
        {
            Artist artist = await artDbRepo.GetArtistById(artistId);
            artist = artDbRepo.UpdateArtist(artist, about);
            ArtistViewModel viewModel = new ArtistViewModel(artist);
            return View("Index", viewModel);
        }

    }
}
