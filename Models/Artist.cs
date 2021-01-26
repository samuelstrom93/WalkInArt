using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Name { get; set; }
        [MaxLength(4000)]
        public string About { get; set; }
        public List<Collection> Collections { get; set; }
    }
}
