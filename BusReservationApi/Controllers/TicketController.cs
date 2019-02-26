using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusReservationApi.Model;
using BusReservationApi.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusReservationApi.Controllers
{
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        TicketService ticketService = new TicketService();
       
        // GET: api/<controller>
      /*  [HttpGet("all")]
        public IEnumerable<Ticket> GetAllTickets()
        {
            return ticketService.

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Ticket GetTicket( int id )
        {
            return ticketService
        }

        // POST api/<controller>
        [HttpPost]
        public Ticket Post([FromBody] Ticket value)
        {
            return ticketService
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Ticket Put(int id, [FromBody]Ticket value)
        {
            return ticketService
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return ticketService
        }*/
    }
}