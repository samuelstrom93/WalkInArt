using DSU21_2.Models;
using System.Collections.Generic;

namespace DSU21_2.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel(List<Collection> currentCollections, List<Collection> incomingCollections, List<Tag> categories)
        {
            CurrentCollections = (List<Collection>)currentCollections;
            IncomingCollections = (List<Collection>)incomingCollections;
            Categories = (List<Tag>)categories;
        }

        public List<Collection> CurrentCollections { get; set; }
        public List<Collection> IncomingCollections { get; set; }
        public List<Tag> Categories { get; set; }
    }
}

