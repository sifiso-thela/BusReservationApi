using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.Model;
using BusReservationApi.Service;

namespace BusReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        // CustomerService customersirvice=new CustomerService();
        AgentService agentService = new AgentService();
        /*[HttpGet("/all")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return agentService
        }
        [HttpGet("{id}")]
        public  Customer GetCustomer(int id)
        {
            return agentService;
        }
        // POST api/<controller>
        [HttpPost]
        public Customer Post([FromBody] Customer value)
        {
            return agentService;

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Trip Put(int id, [FromBody] Trip value)
        {
            return agentService;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return agentService;
        }*/
    }
}