using BusReservationApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BusReservationApi.DB
{
    public class CustomerDAO
    {
        private DB db;

        public CustomerDAO()
        {
            db = new DB();
        }

        public Customer CreateCustomer(Customer customer)
        {
            Customer new_customer = new Customer();
            string query = string.Format("INSERT INTO customer {0}", GenerateInsertString(customer));
            MySqlDataReader mySqlDataReader = (MySqlDataReader) db.Query(query, "customer");
            new_customer = SetCustomers(mySqlDataReader)[0];
            return new_customer;
        }

        public Customer Get(int id)
        {
            Customer customer = new Customer();
            string query = string.Format("SELECT * FROM customer WHERE id = {0}", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader != null)
            {
                if (mySqlDataReader.HasRows)
                {
                    customer = SetCustomers(mySqlDataReader)[0];
                }
            }
            return null;
        }

        public List<Customer> Get()
        {
            string query = string.Format("SELECT * FROM customer");
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            return SetCustomers(mySqlDataReader);
        }

        public bool Delete(int id)
        {
            string query = string.Format("DELETE FROM customer WHERE id = ", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Customer customer)
        {
            string query = string.Format("DELETE FROM customer WHERE id = ", customer.Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }

        public Customer Update(Customer customer)
        {
            Customer updatedCustomer = new Customer();
            string query = string.Format("UPDATE customer ", GenerateUpdateString(customer));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            mySqlDataReader.Close();
            updatedCustomer = Get(int.Parse(customer.Id));
            return updatedCustomer;
        }

        private List<Customer> SetCustomers(MySqlDataReader mySqlDataReader)
        {
            List<Customer> customers = new List<Customer>();
            
            while(mySqlDataReader.Read())
            {
                Customer customer = new Customer
                {
                    Id = mySqlDataReader.GetInt32(0).ToString(),
                    Name = mySqlDataReader.GetString(1).ToString(),
                    Surname = mySqlDataReader.GetString(2).ToString(),
                    Next_of_kin = mySqlDataReader.GetString(4).ToString(),
                    Next_of_kin_number = mySqlDataReader.GetString(5).ToString(),
                    Phone = mySqlDataReader.GetString(3).ToString()
                };
                customers.Add(customer);
            }

            mySqlDataReader.Close();
            return customers;
        }

        private string GenerateInsertString(Customer customer)
        {
            return string.Format("(name,surname,phone,next_of_kin_name,next_of_kin_number) VALUES('{0}', '{1}','{2}','{3}','{4}')", customer.Name, customer.Surname, customer.Phone, customer.Next_of_kin, customer.Next_of_kin_number);
        }

        private string GenerateUpdateString(Customer customer)
        {
            return string.Format("SET name = '{0}',surname = '{1}',phone = '{2}',next_of_kin_name = '{3}',next_of_kin_number = '{4}' WHERE id = {5}", customer.Name, customer.Surname, customer.Phone, customer.Next_of_kin, customer.Next_of_kin_number, customer.Id);
        }
    }
}
