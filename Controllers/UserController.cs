using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private TravelAPIContext _db;

        public UsersController(TravelAPIContext db)
        {
            _db = db;
        }

        // GET api/AllUsers
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get(string name)
        {
          var query = _db.Users.AsQueryable();

          if(name != null)
          {
            query = query.Where(entry => entry.Name == name);
          }

          return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
          return _db.Users.FirstOrDefault(entry => entry.UserId == id);
        }


        // POST api/Users
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        //DELETE api/User
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var userToDelete = _db.Users.FirstOrDefault(entry => entry.UserId == id);
            _db.Users.Remove(userToDelete);
            _db.SaveChanges();
        }

        // PUT api/Users
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            user.UserId = id;
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}