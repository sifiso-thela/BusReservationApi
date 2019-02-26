using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
using BusReservationApi.DB;

namespace BusReservationApi.Service
{
    public class RentalService
    {
        RentalDAO rentalDAO = new RentalDAO();

        public RentalService()
        {
        }
        /*
        public IEnumerable<Rental> GetAllRentals()
        {
            return rentalDAO.Get();
        }

        public Rental GetRental(int id)
        {
            return rentalDAO.Get(id);
        }

        public Rental CreateRental(Rental rental)
        {
            return rentalDAO.Create(rental);
        }

        public Rental UpdateRental(Rental rental)
        {
            return rentalDAO.Update(rental);
        }

        public bool DeleteRental(int id)
        {
            return rentalDAO.Delete(id);
        }
        */
    }
}
