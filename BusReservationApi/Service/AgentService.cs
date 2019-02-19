using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.DB;
using BusReservationApi.Model;

namespace BusReservationApi.Service
{
    public class AgentService
    {
        AgentDAO agentDAO = new AgentDAO();

        public AgentService()
        {
        }
        //ready for AgentDAO implementation
        /*
        public IEnumerable<Agent> getAllAgents()
        {
            return agentDAO.Get();
        }

        public Agent getAgent(int id)
        {
            return agentDAO.Get(id);
        }
        
        public Agent createCustomer(Agent agent)
        {
            return agentDAO.Create(agent);
        }

        public Agent updateCustomer(Agent agent)
        {
            return agentDAO.Update(agent);
        }

        public bool deleteCustomer(int id)
        {
            return agentDAO.Delete(id);
        }
        */
    }
}
