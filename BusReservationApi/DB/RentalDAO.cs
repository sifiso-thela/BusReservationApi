using BusReservationApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BusReservationApi.DB
{
    public class RentalDAO
    {
        private DB db;

        private BusDAO busDAO = new BusDAO();
        public RentalDAO()
        {
            db = new DB();
        }
        public Rental CreateRental(Rental rental)
        {
            string query = string.Format("INSERT INTO rental {0}", GenerateInsertString(rental));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "rental");
            return rental;
        }

        public Rental Get(int Id)
        {
            Rental rental = new Rental();
            string query = string.Format("SELECT * FROM rental WHERE id = {0}", Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "rental");
            if (mySqlDataReader != null)
            {
                if (mySqlDataReader.HasRows)
                {
                    rental = SetRentals(mySqlDataReader)[0];
                }
            }
            return null;
        }
        public List<Rental> Get()
        {
            string query = string.Format("SELECT * FROM rental");
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "rental");
            return SetRentals(mySqlDataReader);
        }
        public bool Delete(int Id)
        {
            string query = string.Format("DELETE FROM rental WHERE id = ", Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "rental");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }
        public bool Delete(Rental rental)
        {
            string query = string.Format("DELETE FROM rental WHERE id = ", rental.Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "rental");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }
        public Rental Update(Rental rental)
        {
            Rental updatedRental = new Rental();
            string query = string.Format("UPDATE driver ", GenerateUpdateString(rental));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "rental");
            mySqlDataReader.Close();
            updatedRental = Get(int.Parse(rental.Id));
            return updatedRental;
        }
        private List<Rental> SetRentals(MySqlDataReader mySqlDataReader)
        {
            List<Rental> rentals = new List<Rental>();

            while (mySqlDataReader.Read())
            {
                Rental rental = new Rental
                {
                    Id = mySqlDataReader.GetInt32(0).ToString(),
                    Bus = new Bus { Id = mySqlDataReader.GetInt32(1).ToString() },
                    Customer = new Customer { Id = mySqlDataReader.GetInt32(3).ToString() },
                    Rented_date = mySqlDataReader.GetDateTime(0),
                    Date_rented = mySqlDataReader.GetDateTime(1),
                    Amount = mySqlDataReader.GetFloat(1),
                    number_of_days = mySqlDataReader.GetInt32(1),
                    Driver = new Driver { Id = mySqlDataReader.GetInt32(2).ToString() },
                    Agent = new Agent { Id = mySqlDataReader.GetInt32(2).ToString() }

                };

              rentals.Add(rental);
            }
            mySqlDataReader.Close();
            return rentals;

        }

        private string GenerateInsertString(Rental rental)
        {
            return string.Format("(Id,Bus,Customer,Rented_date,Date_rented,Amount,number_of_days,Driver,Agent) VALUES('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", rental.Id, rental.Bus.Id,rental.Customer,rental.Rented_date,rental.Date_rented,rental.Amount,rental.number_of_days,rental.Driver.Id,rental.Agent.Id);
        }

        private string GenerateUpdateString(Rental rental)
        {
            return string.Format("SET Id = '{0}',Bus = '{1}',Customer = '{2}',Rented_date = '{3}',Date_rented = '{4}', Amount = '{5}',Number_of_days ='{6}', Driver = '{7}',Agent = '{8}' WHERE id = {8}", rental.Id, rental.Bus.Id, rental.Customer, rental.Rented_date, rental.Date_rented, rental.Amount, rental.number_of_days, rental.Driver.Id, rental.Agent.Id);
        }
    }
}



