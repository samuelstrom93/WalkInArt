using DSU21_2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

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
