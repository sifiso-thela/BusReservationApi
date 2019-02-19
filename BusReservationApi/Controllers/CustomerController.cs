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
    public class CustomerController : Controller
    {
        CustomerService customerService = new CustomerService();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customerService.getAllCustomers();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return customerService.getCustomer(id);
        }

        // POST api/<controller>
        [HttpPost]
        public Customer Post([FromBody]Customer customer)
        {
            return customerService.createCustomer(customer);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Customer Put(int id, [FromBody]Customer customer)
        {
            return customerService.updateCustomer(customer);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return customerService.deleteCustomer(id);
        }
    }
}
