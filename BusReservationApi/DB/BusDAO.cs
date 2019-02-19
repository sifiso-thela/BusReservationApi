using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
using MySql.Data;
using MySql.Data.MySqlClient; 

namespace BusReservationApi.DB
{
    public class BusDAO
    {
        private DB db;

        public BusDAO()
        {
            db = new DB();
        }

        public Bus Create(Bus bus)
        {
            Bus new_bus = new Bus();
            string query = string.Format("INSERT INTO bus {0}", GenerateInsertString(bus));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "bus");
            new_bus = SetBuses(mySqlDataReader)[0];
            return new_bus;
        }

        public Bus Update(Bus bus)
        {
            Bus updatedBus = new Bus();

            string query = string.Format("UPDATE bus ", GenerateUpdateString(bus));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "bus");
            mySqlDataReader.Close();
            updatedBus = Get(int.Parse(bus.Id));

            return updatedBus;
        }

        public List<Bus> Get()
        {
            string query = string.Format("SELECT * FROM bus");
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "bus");
            return SetBuses(mySqlDataReader);
        }

        public Bus Get(int id)
        {
            Bus bus = new Bus();
            string query = string.Format("SELECT * FROM bus WHERE id = {0}", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader != null)
            {
                if (mySqlDataReader.HasRows)
                {
                    bus = SetBuses(mySqlDataReader)[0];
                }
            }
            return null;
        }

        public bool Delete(int id)
        {
            string query = string.Format("DELETE FROM bus WHERE id = ", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Bus bus)
        {
            string query = string.Format("DELETE FROM customer WHERE id = ", bus.Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "customer");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }



        private List<Bus> SetBuses(MySqlDataReader mySqlDataReader)
        {
            List<Bus> buses = new List<Bus>();

            while (mySqlDataReader.Read())
            {
                Bus bus = new Bus
                {
                    Id = mySqlDataReader.GetInt32(0).ToString(),
                    Name = mySqlDataReader.GetString(1),
                    Bus_type = mySqlDataReader.GetString(2),
                    Reg_no = mySqlDataReader.GetString(3),
                    Num_seat = mySqlDataReader.GetInt32(4)
                };

                buses.Add(bus);
            }
            mySqlDataReader.Close();
            return buses;
        }

        private string GenerateInsertString(Bus bus)
        {
            return string.Format("(name,bus_type,reg_no,seats) VALUES('{0}', '{1}','{2}','{3}')", bus.Name, bus.Bus_type, bus.Reg_no, bus.Num_seat);
        }

        private string GenerateUpdateString(Bus bus)
        {
            return string.Format("SET name = '{0}',bus_type = '{1}',reg_no = '{2}',seats = '{3}' WHERE id = {4}", bus.Name, bus.Bus_type, bus.Reg_no, bus.Num_seat, bus.Id);
        }
    }



}
