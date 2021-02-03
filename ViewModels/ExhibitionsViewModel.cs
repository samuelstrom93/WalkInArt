using DSU21_2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.ViewModels
{
    public class ExhibitionsViewModel
    {
        public Collection Exhibitions { get; set; }
        public List<Collection> ExhibitionsForRooms { get; set; }
        public Artist Artist { get; set; }

        public ExhibitionsViewModel(Collection exhibitions, List<Collection> exhibitionsForRooms, Artist artist)
        {
            Exhibitions = exhibitions;
            ExhibitionsForRooms = exhibitionsForRooms;
            Artist = artist;
        }

    }
}
