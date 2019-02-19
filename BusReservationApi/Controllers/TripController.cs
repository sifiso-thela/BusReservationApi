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
        CustomerService customerService = new CustomerService();
        [HttpGet("all")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerService.getAllCustomers();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Customer GetCustomer(string id)
        {
            return customerService.getCustomer(id);
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
