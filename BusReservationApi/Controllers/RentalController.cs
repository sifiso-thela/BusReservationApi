using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.Model;
using BusReservationApi.Service;
namespace BusReservationApi.Controllers
{
    [Route("api/[controller]")]
    public class RentalController : Controller
    {
        RentalService rentalService = new RentalService();
        
       /* [HttpGet("all")]
        public IEnumerable<Rental> GetAllRentals()
        {
            return rentalService.
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Rental  GetRental(int id)
        {
            return rentalService.
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
