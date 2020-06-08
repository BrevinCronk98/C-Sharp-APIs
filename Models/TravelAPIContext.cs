using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelAPIContext : DbContext
    {
        public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                new User { UserId = 1, Name = "Matilda"},
                new User { UserId = 2, Name = "Rexie"},
                new User { UserId = 3, Name = "Matilda"},
                new User { UserId = 4, Name = "Pip"},
                new User { UserId = 5, Name = "Bartholomew"}
            );
            builder.Entity<Location>()
            .HasData(
                new Location { LocationId = 1, Name = "France", Rating = 5, Review = "Super frenchy"},
                new Location { LocationId = 2, Name = "Germany", Rating = 4, Review = "Super Garmanyny"},
                new Location { LocationId = 3, Name = "Ireland", Rating = 4, Review = "Super Irelandy"},
                new Location { LocationId = 4, Name = "Spain", Rating = 2, Review = "Super spainy"},
                new Location { LocationId = 5, Name = "Antarctica", Rating = 5, Review = "Super cold"}
            );
        }
    }
}