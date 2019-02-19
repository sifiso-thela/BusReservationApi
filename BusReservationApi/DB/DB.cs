using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace BusReservationApi.DB
{
    public class DB
    {
        private MySqlConnection conn;

        public DB()
        {
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", "127.0.0.1", "bookingapp", "root", "1O5t123#");
            conn = new MySqlConnection(connstring);
            conn.Open();
        }

        public Object Query(string query, string table)
        {
            query = query.Trim();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            if(!query.Substring(0,1).ToUpper().Contains("D"))
            {
                if (query.Substring(0, 1).ToUpper().Contains("I")) {
                    cmd = new MySqlCommand("select LAST_INSERT_ID()", conn);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    mySqlDataReader.Read();
                    int id = mySqlDataReader.GetInt32(0);
                    mySqlDataReader.Close();
                    query = string.Format("SELECT * FROM {0} WHERE id = {1}", table, id.ToString());
                    cmd = new MySqlCommand(query, conn);
                    mySqlDataReader = cmd.ExecuteReader();
                    return mySqlDataReader;
                }
                else
                {
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    return mySqlDataReader;
                }
            }
            else
            {
                cmd.ExecuteNonQuery();
                return null;
            }
        }

        public void Close()
        {
            conn.Close();
        }


        public bool IsConnect()
        {
            if (conn == null)
            {
                return false;
            }
            return true;
        }

        public void Open()
        {
            conn.Open();
        }
    }
}
