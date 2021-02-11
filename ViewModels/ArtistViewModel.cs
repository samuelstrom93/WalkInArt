using DSU21_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
