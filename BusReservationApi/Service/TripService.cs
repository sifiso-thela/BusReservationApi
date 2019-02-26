using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
using BusReservationApi.DB;

namespace BusReservationApi.Service
{
    public class TripService
    {
        TripDAO TripDAO = new TripDAO();
<<<<<<< HEAD
=======
        //Ready for TicketDAO implementation
       
>>>>>>> 5e82449416c0eec05f715f141ebac4722f04ae47
        public TripService()
        {

        }
        
        public IEnumerable<Trip> GetAllTrip()
        {
            try
            {
                return TripDAO.Get();
            }catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public Trip GetTrip(int id)
        {
            return TripDAO.Get(id);
        }

        public Trip CreateTrip(Trip trip)
        {
            return TripDAO.Create(trip);
        }

        public Trip UpdateTrip(Trip trip)
        {
            return TripDAO.Update(trip);
        }

        public bool DeleteTrip(int id)
        {
            return TripDAO.Delete(id);
        }
        
    }
}
