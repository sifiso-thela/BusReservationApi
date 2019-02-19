using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
using BusReservationApi.Controllers;
using BusReservationApi.DB;

namespace BusReservationApi.Service
{
    public class CustomerService
    {
<<<<<<< HEAD
        private List<Customer> customers;
        /*
        private CustomerContext _context;
        
        public CustomerService(CustomerContext context)
        {
            this._context = context;
            
        }
        */
        public CustomerService()
        {
            customers = new List<Customer>()
            {
                new Customer("1", "Name", "Surname", "0659024156", "Next", "rt"),
                new Customer("2", "sam", "khoza", "01234545678", "of", "yty"),
                new Customer("3", "nkosi", "smith", "0974521575", "kin", "u")
            };
        }
        public IEnumerable<Customer> getAllCustomers()
        {
            return customers;
=======
        CustomerDAO customerDAO = new CustomerDAO();

        public IEnumerable<Customer> getAllCustomers()
        {
            return customerDAO.Get();
>>>>>>> 49c1e2150998980d6cfa62c130f61305f5c5f84b
        }

        public Customer getCustomer(int id)
        {
<<<<<<< HEAD
              
           return customers.Where(cust => cust.Id == id).FirstOrDefault();

=======
            return customerDAO.Get(id);
>>>>>>> 49c1e2150998980d6cfa62c130f61305f5c5f84b
        }
        /*
        public bool doesCustomerExist(string id)
        { 
            return this.customers.Any(cust => cust.Id == id);
        }
        */
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
