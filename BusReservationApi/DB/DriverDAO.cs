using BusReservationApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace BusReservationApi.DB
{
    public class DriverDAO
    {
        private DB db;

        public DriverDAO()
        {
            db = new DB();
        }
        public Driver CreateCustomer(Driver driver)
        {
            string query = string.Format("INSERT INTO driver {0}", GenerateInsertString(driver));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "driver");
            return driver;
        }
        public Driver Get(int id)
        {
            Driver driver = new Driver();
            string query = string.Format("SELECT * FROM driver WHERE id = {0}", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "driver");
            if (mySqlDataReader != null)
            {
                if (mySqlDataReader.HasRows)
                {
                   driver = SetDrivers(mySqlDataReader)[0];
                }
            }
            return null;
        }

        public List<Driver> Get()
        {
            string query = string.Format("SELECT * FROM driver");
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "driver");
            return SetDrivers(mySqlDataReader);
        }

        public bool Delete(int id)
        {
            string query = string.Format("DELETE FROM driver WHERE id = ", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "driver");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }
        public bool Delete(Driver driver)
        {
            string query = string.Format("DELETE FROM driver WHERE id = ", driver.Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "driver");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }
        public Driver Update(Driver driver)
        {
            Driver updatedDriver = new Driver();
            string query = string.Format("UPDATE driver ", GenerateUpdateString(driver));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "driver");
            mySqlDataReader.Close();
            updatedDriver = Get(int.Parse(driver.Id));
            return updatedDriver;
        }
        private List<Driver> SetDrivers(MySqlDataReader mySqlDataReader)
        {
            List<Driver> drivers = new List<Driver>();

            while (mySqlDataReader.Read())
            {
                Driver driver = new Driver
                {
                    Id = mySqlDataReader.GetInt32(0).ToString(),
                    Name = mySqlDataReader.GetString(1).ToString(),
                    Surname = mySqlDataReader.GetString(2).ToString(),
                    
                };
                drivers.Add(driver);
            }

            mySqlDataReader.Close();
            return drivers;
        }
        private string GenerateInsertString(Driver driver)
        {
            return string.Format("(name,surname) VALUES('{0}', '{1}')", driver.Name, driver.Surname);
        }
        private string GenerateUpdateString(Driver driver)
        {
            return string.Format("SET name = '{0}',surname = '{1}', WHERE id = {5}", driver.Name, driver.Surname);
        }
    }
}
