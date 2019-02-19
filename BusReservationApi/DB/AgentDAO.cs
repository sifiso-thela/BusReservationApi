using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BusReservationApi.DB
{
    public class AgentDAO
    {
        private DB db;

        public AgentDAO()
        {
            db = new DB();
        }

        public Agent CreateAgent(Agent agent)
        {
            Agent new_agent = new Agent();
            string query = string.Format("INSERT INTO agent {0}", GenerateInsertString(agent));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "agent");
            return new_agent;
        }

        public Agent Get(int id)
        {
            Agent agent = new Agent();
            string query = string.Format("SELECT * FROM agent WHERE id = {0}", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "agent");
            if (mySqlDataReader != null)
            {
                if (mySqlDataReader.HasRows)
                {
                    agent = SetAgents(mySqlDataReader)[0];
                }
            }
            return null;
        }

        public List<Agent> Get()
        {
            string query = string.Format("SELECT * FROM agent");
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "agent");
            return SetAgents(mySqlDataReader);
        }

        public bool Delete(int id)
        {
            string query = string.Format("DELETE FROM agent WHERE id = ", id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "agent");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Agent agent)
        {
            string query = string.Format("DELETE FROM agent WHERE id = ", agent.Id.ToString());
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "agent");
            if (mySqlDataReader == null)
            {
                return true;
            }
            return false;
        }

        public Agent Update(Agent agent)
        {
            Agent updatedAgent = new Agent();
            string query = string.Format("UPDATE agent ", GenerateUpdateString(agent));
            MySqlDataReader mySqlDataReader = (MySqlDataReader)db.Query(query, "agent");
            mySqlDataReader.Close();
            updatedAgent = Get(int.Parse(agent.Id));
            return updatedAgent;
        }

        private List<Agent> SetAgents(MySqlDataReader mySqlDataReader)
        {
            List<Agent> agents = new List<Agent>();

            while (mySqlDataReader.Read())
            {
                Agent agent = new Agent
                {
                    Id = mySqlDataReader.GetInt32(0).ToString(),
                    Name = mySqlDataReader.GetString(1).ToString(),
                    Surname = mySqlDataReader.GetString(2).ToString(),
                    Phone = mySqlDataReader.GetString(3).ToString(),
                    Email = mySqlDataReader.GetString(4).ToString(),
                    Password = mySqlDataReader.GetString(5).ToString()
                    
                };
                agents.Add(agent);
            }

            mySqlDataReader.Close();
            return agents;
        }

        private string GenerateInsertString(Agent agent)
        {
            return string.Format("(name,surname,phone,email,password) VALUES('{0}', '{1}','{2}','{3}','{4}')", agent.Name, agent.Surname, agent.Phone, agent.Email, agent.Password);
        }

        private string GenerateUpdateString(Agent agent)
        {
            return string.Format("SET name = '{0}',surname = '{1}',phone = '{2}',email = '{3}',password = '{4}' WHERE id = {5}", agent.Name, agent.Surname, agent.Phone, agent.Email, agent.Password, agent.Id);
        }
    }
}
