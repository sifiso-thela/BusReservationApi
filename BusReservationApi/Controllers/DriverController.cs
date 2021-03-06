﻿using System;
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
        [HttpPost("{id}")]
        public Driver Post([FromBody]Driver value)
        {
            return driverService.createDriver(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Driver Put(int id, [FromBody]Driver value)
        {
            return driverService.updateDriver(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return driverService.deleteDriver(id);
        }
    }
}
