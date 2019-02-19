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
            string query = string.Format("INSERT INTO trip {0}", GenerateInsertString(trip));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "trip");
            new_trip = SetTrips(mySqlDataReader)[0];
            return new_trip;
        }

        public List<Trip> Get()
        {
            List<Trip> trips = new List<Trip>();
            string query = string.Format("SELECT * FROM trip");
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "trip");
            trips = SetTrips(mySqlDataReader);
            return trips;
        }

        public Trip Get(int id)
        {
            Trip trip = new Trip();
            string query = string.Format("SELECT * FROM trip WHERE id = {0}", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "trip");
            if (mySqlDataReader != null)
            {
                if (mySqlDataReader.HasRows)
                {
                    trip = SetTrips(mySqlDataReader)[0];
                }
            }
            return null;
        }

        public Trip Update(Trip trip)
        {
            Trip updatedTrip = new Trip();
            string query = string.Format("UPDATE trip ", GenerateUpdateString(trip));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "trip");
            mySqlDataReader.Close();
            updatedTrip = Get(int.Parse(trip.Id));
            return updatedTrip;
        }
        
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
                    Id = mySqlDataReader.GetString(0),
                    Bus = new Bus {Id = mySqlDataReader.GetString(1) },
                    Driver = new Driver { Id =mySqlDataReader.GetString(2) },
                    Date = mySqlDataReader.GetDateTime(3),
                    Depature_time = mySqlDataReader.GetDateTime(5),
                    Arrival_time = mySqlDataReader.GetDateTime(5),
                    Starting_point = mySqlDataReader.GetString(6),
                    Destination = mySqlDataReader.GetString(7),
                    Price = mySqlDataReader.GetFloat(8)
                };
            }
            mySqlDataReader.Close();
            trips = setTripObjects(trips);
            return trips;
        }

        private List<Trip> setTripObjects(List<Trip> trips)
        {
            List<Trip> new_trips = trips;
            DriverDAO driverDAO = new DriverDAO();
            BusDAO busDAO = new BusDAO();
            for (int i = 0; i < trips.Count; i++)
            {
                trips[i].Driver = driverDAO.Get(int.Parse(trips[i].Driver.Id));
                trips[i].Bus = busDAO.Get(int.Parse(trips[i].Bus.Id));
            }

            return new_trips;
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
