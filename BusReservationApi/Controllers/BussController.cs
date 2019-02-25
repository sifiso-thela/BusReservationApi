using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.Service;
using BusReservationApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussController : Controller
    {
        BusService busService = new BusService();
        // GET: api/<controller>
        [HttpGet("all")]
        public IEnumerable<Bus> GetAllBusses()
        {
            return busService.GetAllBusses();
        }
        [HttpGet("{id}")]
        public Bus GetBus(int id)
        {
            return busService.GetBus(id);
        }
        // POST api/<controller>
        [HttpPost]
        public Bus Post([FromBody]Bus value)
        {
            return busService.CreateBus(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Bus Put(int id, [FromBody]Bus value)
        {

            return busService.UpdateBus(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return busService.DeleteBus(id);
        }
    }
}
