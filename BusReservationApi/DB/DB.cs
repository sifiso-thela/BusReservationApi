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
            //string connstring = string.Format("server={0};port={1};uid={2};pwd={3};database={4};SslMode={5}", "localhost","3306","root","1O5t123#", "bookingapp", "none");
            string connstring = "Persist Security Info=False;database=bookingapp;server=192.168.17.238;Connect Timeout=30;user id=root; pwd=some_pass";
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
                    cmd.ExecuteNonQuery();
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
