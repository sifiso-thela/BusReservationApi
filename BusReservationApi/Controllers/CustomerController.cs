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


        Customer[] customers = new Customer[]
        {
            new  Customer { Id = "1", Name  = "Tomato Soup", Surname = "Groceries", Phone = "04454444",Next_of_kin="zolile" },
            new  Customer { Id = "2", Name  = "Tomato Soup", Surname = "Groceries", Phone = "555555554",Next_of_kin="zolile" },
            new  Customer { Id = "3", Name  = "Tomato Soup", Surname = "Groceries", Phone = "077777777",Next_of_kin="zolile" },
            new  Customer { Id = "4", Name  = "Tomato Soup", Surname = "Groceries", Phone = "048888884",Next_of_kin="zolile" },
            new  Customer { Id = "6", Name  = "Tomato Soup", Surname = "Groceries", Phone = "0488888884",Next_of_kin="zolile" },


        };
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetCustomer(string id)
        {
            var customer = customers.FirstOrDefault((p) => p.Id == id);
            return customer;
        }


    }
}