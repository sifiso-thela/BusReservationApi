using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.Model;
using BusReservationApi.Service;


namespace BusReservationApi.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        CustomerService customerservice;
        [HttpGet("/all")]
        public IEnumerable<Customer> GetALLCustomers()
        {
            return customerservice.getAllCustomers();
        }
        [HttpGet("{id}")]
        public Customer GetCustomer(string id)
        {
            return customerservice.getCustomer(id);
        }

    }
}