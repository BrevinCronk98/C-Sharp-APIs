using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace TravelApi.Models
{
  public class Location
  {
      public Location()
      {
          this.Users = new HashSet<LocationUser>();
      }
    public int LocationId { get; set; }
    public string Name { get; set;}
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set;}
    
    public string Review {get; set;}
    public virtual ICollection<LocationUser> Users { get; set; }
  }
}