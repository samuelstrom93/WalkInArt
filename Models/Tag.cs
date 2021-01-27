using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSU21_2.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get;  set; }
        public List<Collection> Collections  { get; set; }
    }
}
