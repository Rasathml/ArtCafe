namespace ArtCafe.Server.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public int ArtworkId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        // Add other properties as needed

        public Artwork Artwork { get; set; }
        public User User { get; set; }
    }
}

