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
    public class CustomerController : ControllerBase
    {
        CustomerService customerService;
        
        [HttpGet("/all")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerService.getAllCustomers();
        }

        [HttpGet("{id}")]
        
        public Customer getCustomer(string id)
        {

            return customerService.getCustomer(id);
            
        }
    

    }

    public interface IHttpActionResult 
    {
      
    }
   
}