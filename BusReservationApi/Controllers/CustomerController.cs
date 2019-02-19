using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.Model;
using BusReservationApi.Service;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace BusReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
         CustomerService customerService=new CustomerService();

        [HttpGet("all")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerService.getAllCustomers();            
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
<<<<<<< HEAD
        public Customer GetCustomer(string id)
=======

        public Customer getCustomer(int id)
>>>>>>> 49c1e2150998980d6cfa62c130f61305f5c5f84b
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
