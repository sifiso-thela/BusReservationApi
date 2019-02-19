using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;

namespace BusReservationApi.Service
{
    interface CustomerInterface
    {
        IEnumerable<Customer> getAllCustomers();
        Customer getCustomer(int id);
        //bool doesCustomerExist(string ig);
        Customer createCustomer(Customer customer);
        Customer updateCustomer(Customer customer);
        bool deleteCustomer(int id);
        
    }
}
