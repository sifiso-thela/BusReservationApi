using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.DB;
using BusReservationApi.Model;
using BusReservationApi.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusReservationApi.Controllers
{
    [Route("api/[controller]")]
    public class DriverController : Controller
    {
        DriverService driverService = new DriverService();

        // GET: api/<controller>
        [HttpGet("all")]
        public IEnumerable<Driver> GetAllDrivers()
        {
            return driverService.GetAllDrivers();
        }

        [HttpGet("{id}")]
        public Driver GetDriver(int id)
        {
            return driverService.GetDriver(id);
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
