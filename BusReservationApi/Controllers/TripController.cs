using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.Model;
using BusReservationApi.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusReservationApi.Controllers
{
    [Route("api/[controller]")]
    public class TripController : Controller
    {
        TripService tripService = new TripService();
        // GET: api/<controller>
        [HttpGet("all")]
        public IEnumerable<Trip> GetAllTrips()
        {
            return tripService.GetAllTrip();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Trip GetTrip(int id )
        {
            return tripService.GetTrip(id);
        }

        // POST api/<controller>
        [HttpPost]
        public Trip Post([FromBody] Trip value)
        {
            return tripService.CreateTrip(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Trip Put(int id, [FromBody] Trip value)
        {
            return tripService.UpdateTrip(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return tripService.DeleteTrip(id);
        }
    }
}
