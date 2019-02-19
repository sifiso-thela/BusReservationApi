using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BusReservationApi.DB
{
    public class TripDAO
    {
        private DB db;

        public TripDAO()
        {
            db = new DB();
        }

        public Trip Create(Trip trip)
        {
            Trip new_trip = new Trip();
            string query = string.Format("INSERT INTO customer {0}", GenerateInsertString(trip));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            new_trip = SetTrips(mySqlDataReader)[0];
            return new_trip;
        }

        /*
        public List<Trip> Get()
        {

        }

        public Trip Get(int id)
        {

        }

        public Trip Update(Trip trip)
        {

        }
    */
        public bool Delete(int id)
        {
            string query = string.Format("DELETE FROM trip WHERE id = ", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Trip trip)
        {
            string query = string.Format("DELETE FROM trip WHERE id = ", trip.Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }

        private List<Trip> SetTrips(MySqlDataReader mySqlDataReader)
        {
            List<Trip> trips = new List<Trip>();
            while (mySqlDataReader.Read())
            {
                Trip trip = new Trip
                {

                };
            }
            return trips;
        }

        private string GenerateInsertString(Trip trip)
        {
            return string.Format("(bus_id,driver_id,departure_date,departure_time,arrival_time,departure_place,destination,price) VALUES('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}')", trip.Bus.Id, trip.Driver.Id, trip.Date.Date, trip.Depature_time, trip.Arrival_time, trip.Starting_point, trip.Destination, trip.Price);
        }

        private string GenerateUpdateString(Trip trip)
        {
            return string.Format("SET bus_id = '{0}',driver_id = '{1}',departure_date = '{2}',departure_time = '{3}',arrival_time = '{4}', departure_place = '{5}',destination ='{6}', price = '{7}' WHERE id = {8}",trip.Bus.Id,trip.Driver.Id,trip.Date.Date,trip.Depature_time,trip.Arrival_time,trip.Starting_point,trip.Destination,trip.Price,trip.Id );
        }
    }
}
