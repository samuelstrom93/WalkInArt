using DSU21_2.Models;

namespace DSU21_2.ViewModels
{
    public class ArtistViewModel
    {
        public Artist Artist { get; set; }
        public ArtistViewModel(Artist artist)
        {
            this.Artist = artist;
        }
    }

}
