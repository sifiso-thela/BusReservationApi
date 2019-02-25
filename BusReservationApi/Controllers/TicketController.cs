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
       // [HttpGet("all")]
       /* public IEnumerable<Ticket> GetAllTickets()
        {
            return ticketService

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Ticket GetTicket( int id )
        {
            return ticketService
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}