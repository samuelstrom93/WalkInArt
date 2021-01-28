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
        public ExhibitionsViewModel(Collection exhibitions)
        {
            Exhibitions = exhibitions;
        }
        public Collection Exhibitions { get; set; }
        
    }
}
