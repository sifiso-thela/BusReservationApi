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
        Customer getCustomer(string id);
        bool doesCustomerExist(string ig);
        void createCustomer(Customer customer);
        void updateCustomer(Customer customer);
        void deleteCustomer(string id);
        
    }
}
