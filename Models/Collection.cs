using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Artwork> Artworks { get; set; }
    }
}
