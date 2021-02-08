using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.ViewModels
{
    public class ArtistViewModel
    {
        public ArtistViewModel(string profileId, string profileFirstName)
        {
            this.ProfileId = profileId;
            this.ProfileFirstName = profileFirstName;
        }

        public string ProfileId { get; set; }
        public string ProfileFirstName { get; set; }
    }

}
