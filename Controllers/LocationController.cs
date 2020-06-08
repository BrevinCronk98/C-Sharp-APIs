using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationsController: ControllerBase
  {
    private TravelAPIContext _db;

    public LocationsController(TravelAPIContext db)
    {
      _db = db;
    }

    // GET api/Locations
    [HttpGet]
    public ActionResult<IEnumerable<Location>> Get(string name, string review, int rating)
    {
        var query = _db.Locations.AsQueryable();
        if (name != null)
        {
            query = query.Where(entry => entry.Name == name);
        }
        if (review != null)
        {
            query = query.Where(entry => entry.Review == review);
        }
        if(rating != 0)
        {
            query = query.Where(entry => entry.Rating == rating);
        }
      return query.ToList();
    }
    
    // GET api/Locations/5
    [HttpGet("{id}")]
    public ActionResult<Location> Get(int id)
    {
      return _db.Locations.Include(entry => entry.Users).ThenInclude(join => join.User).Where(entry => entry.LocationId == id).FirstOrDefault();
    }

    [HttpGet("randomlocation")]
    public ActionResult<Location> GetRandom()
    {
      Random rand = new Random();
      int toSkip = rand.Next(0, _db.Locations.Count());
      return _db.Locations.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).First();
    }
    
    // POST api/Locations
    [HttpPost]
    public void Post([FromBody] Location location)
    {
      _db.Locations.Add(location);
      _db.SaveChanges();
    }
  
    // DELETE api/Locations
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var locationToDelete = _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
        _db.Locations.Remove(locationToDelete);
        _db.SaveChanges();
    }

    // PUT api/Locations
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Location location)
    {
        location.LocationId = id;
        _db.Entry(location).State = EntityState.Modified;
        _db.SaveChanges();
    }
  }

}