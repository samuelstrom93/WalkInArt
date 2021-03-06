using Microsoft.EntityFrameworkCore;
using DSU21_2.Models;

namespace DSU21_2.Data
{
    public class ArtContext : DbContext
    {
        public ArtContext(DbContextOptions<ArtContext> options) : base(options) { }
        public DbSet<Artist> Artists { get; set; } 
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
    }
}
