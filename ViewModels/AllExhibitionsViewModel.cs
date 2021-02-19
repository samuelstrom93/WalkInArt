using DSU21_2.Models;
using System.Collections.Generic;

namespace DSU21_2.ViewModels
{
    public class AllExhibitionsViewModel
    {
        public List<Collection> AllExhibitions { get; set; }

        public AllExhibitionsViewModel(List<Collection> allExhibitions)
        {
            AllExhibitions = allExhibitions;
        }

    }
}
