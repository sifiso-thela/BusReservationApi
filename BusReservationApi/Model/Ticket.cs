using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Ticket
    {
        public string Id { get; set; }
        public Customer customer { get; set; }
        public Trip Trip { get; set; }
        public Agent Agent { get; set; }
        public string seat { get; set; }
        public DateTime Purchase_date { get; set; }

    }
}
