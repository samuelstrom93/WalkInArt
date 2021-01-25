using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get;  set; }
        public List<Collection> Collections { get; set; }
    }
}
