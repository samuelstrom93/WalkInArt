using DSU21_2.Models;
using System.Collections.Generic;


namespace DSU21_2.ViewModels
{
    public class CategoriesViewModel
    {
        public List<Tag> Categories { get; set; }
        public CategoriesViewModel(List<Tag> categories)
        {
            Categories = (List<Tag>)categories;
        }
      

    }
}
