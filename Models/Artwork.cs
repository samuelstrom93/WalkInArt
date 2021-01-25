using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Hyperlink { get; set; }
        public List<Collection> Collections { get; set; }
    }
}
