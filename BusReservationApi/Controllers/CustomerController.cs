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
    [ApiController]
    public class CustomerController : Controller
    {
        CustomerService customerService;

        [HttpGet("all")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerService.getAllCustomers();            
        }

        [HttpGet("{id}")]

        public Customer getCustomer(int id)
        {
            return customerService.getCustomer(id);
        }

    }
}
