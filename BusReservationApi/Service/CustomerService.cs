﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
//using BusReservationApi.Controllers;
using BusReservationApi.DB;

namespace BusReservationApi.Service
{
    public class CustomerService : CustomerInterface
    {
        CustomerDAO customerDAO = new CustomerDAO();

        public CustomerService()
        {
        }

        public IEnumerable<Customer> getAllCustomers()
        {
            return customerDAO.Get();
        }

        public Customer getCustomer(int id)
        {
            return customerDAO.Get(id);
        }
      
        public Customer createCustomer(Customer customer)
        {
            return customerDAO.CreateCustomer(customer);                        
        }

        public Customer updateCustomer(Customer customer)
        {
            return customerDAO.Update(customer);
        }
         
        public bool deleteCustomer(int id)
        {
            return customerDAO.Delete(id);
        }
    }
}
