using System.Collections.Generic;

namespace TravelApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Location> Locations {get; set;}

        public User()
        {
            Locations = new HashSet<Location>();
        }
    }
}