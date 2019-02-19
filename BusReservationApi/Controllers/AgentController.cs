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
        CustomerService customersirvice=new CustomerService();
        [HttpGet("/all")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customersirvice.getAllCustomers();
        }
        [HttpGet("{id}")]
        public  Customer GetCustomer(int id)
        {
            return customersirvice.getCustomer(id);
        }
    }
}