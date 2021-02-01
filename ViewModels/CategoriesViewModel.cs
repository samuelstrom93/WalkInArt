using DSU21_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.ViewModels
{
    public class CategoriesViewModel
    {
        public CategoriesViewModel(List<Tag> categories)
        {
            Categories = (List<Tag>)categories;
            //Category = (List<Tag>)category;
           
        }
        public List<Tag> Categories { get; set; }
        //public Tag Category { get; set; }

        public string Title { get; set; }

    }
}
