using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusReservationApi.Model;
using BusReservationApi.DB;

namespace BusReservationApi.Service
{
    public class TicketService
    {
        TicketDAO ticketDAO = new TicketDAO();

        public TicketService()
        {

        }
        /*
        public IEnumerable<Ticket> GetAllTicket()
        {
            return ticketDAO.Get();
        }

        public Ticket GetTicket(int id)
        {
            return ticketDAO.Get(id);
        }

        public Ticket CreateTicket(Ticket ticket)
        {
            return ticketDAO.Create(ticket);
        }

        public Ticket UpdateTicket(Ticket ticket)
        {
            return ticketDAO.Update(ticket);
        }

        public bool DeleteTicket(int id)
        {
            return ticketDAO.Delete(id);
        }
        */
    }
}
