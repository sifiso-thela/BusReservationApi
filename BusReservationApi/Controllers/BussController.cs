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
        }
    }
}
