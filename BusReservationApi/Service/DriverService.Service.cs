using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.DB;
using BusReservationApi.Model;
using BusReservationApi.Service;

namespace BusReservationApi.Service
{
    public class DriverService
    {
        DriverDAO driverDAO = new DriverDAO();

         public  IEnumerable<Driver> GetAllDrivers()
        {
            return driverDAO.Get();
        }
        public Driver GetDriver(int id)
        {
            return driverDAO.Get(id);
        }

        public Driver createDriver( Driver driver)
        {
            return driverDAO.CreateDriver(driver);
        }

        public Driver  updateDriver(Driver driver)
        {
            return driverDAO.Update(driver);
        }

        public bool deleteDriver(int driver)
        {
            return driverDAO.Delete(driver);

        }










    }
}
