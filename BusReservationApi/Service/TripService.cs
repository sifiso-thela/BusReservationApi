﻿using System;
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
        //Ready for TicketDAO implementation
        /*
        public TripService()
        {

        }
        
        public IEnumerable<Trip> GetAllTrip()
        {
            return TripDAO.Get();
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
        */
    }
}
