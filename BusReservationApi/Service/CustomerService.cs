using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;

namespace BusReservationApi.Service
{
    public class CustomerService : CustomerInterface
    {
        private List<Customer> customers = new List<Customer>()
        {
            new Customer("1", "Name", "Surname", "0659024156", "Next"),
            new Customer("2", "sam", "khoza", "01234545678", "of"),
            new Customer("3", "nkosi", "smith", "0974521575", "kin")
        };

        private CustomerContext _context;

        public CustomerService(CustomerContext context)
        {
            this._context = context;
            
        }
        public IEnumerable<Customer> getAllCustomers()
        {
            return this.customers;
        }

        public Customer getCustomer(string id)
        {
            return this.customers.FirstOrDefault(cust => cust.Id == id);
        }

        public bool doesCustomerExist(string id)
        { 
            return this.customers.Any(cust => cust.Id == id);
        }

        public void createCustomer(Customer customer)
        {
            try
            {
                this.customers.Add(customer);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public void updateCustomer(Customer customer)
        {
            try
            {
                var cust = this.getCustomer(customer.Id);
                var index = this.customers.IndexOf(cust);

                this.customers.RemoveAt(index);
                this.customers.Insert(index, customer);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void deleteCustomer(string id)
        {
            try
            {
                var cust = this.getCustomer(id);
                var index = this.customers.IndexOf(cust);

                this.customers.RemoveAt(index);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
