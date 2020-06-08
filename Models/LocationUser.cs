namespace TravelApi.Models
{
    public class LocationUser
    {
        public int LocationUserId { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
    }
}