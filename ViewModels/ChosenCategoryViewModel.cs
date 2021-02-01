using DSU21_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.ViewModels
{
    public class ChosenCategoryViewModel    
    {
        public Tag ChosenTag { get; set; }

        public ChosenCategoryViewModel(Tag tag)
        { 
            ChosenTag = tag;
 
        }


    }
}
