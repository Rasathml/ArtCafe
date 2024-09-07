using Microsoft.EntityFrameworkCore;
using ArtCafe.Server.Models; // Adjust namespace as needed

namespace ArtCafe.Server.Data
{
    public class ArtCafeContext : DbContext
    {
        public ArtCafeContext(DbContextOptions<ArtCafeContext> options) : base(options) { }

        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}

