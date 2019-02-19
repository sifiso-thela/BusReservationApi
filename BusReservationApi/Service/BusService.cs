using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.DB;
using BusReservationApi.Model;
namespace BusReservationApi.Service
{
    public class BusService
    {
        BusDAO busDAO = new BusDAO();

        public BusService()
        {
        }
        //ready for busDAO implementation
        /*
        public IEnumerable<Bus> GetAllBusses()
        {
            return busDAO.Get();
        }

        public Bus GetBus(int id)
        {
            return busDAO.Get(id);
        }
        
        public Bus CreateCustomer(Bus bus)
        {
            return busDAO.Create(bus);
        }

        public Customer UpdateCustomer(Bus bus)
        {
            return busDAO.Update(bus);
        }

        public bool DeleteCustomer(int id)
        {
            return busDAO.Delete(id);
        }
        */
    }
}
