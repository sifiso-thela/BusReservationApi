using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Ticket
    {
        public string id { get; set; }
        public Customer customer { get; set; }
        public Type Trip { get; set; }
        public string Agent { get; set; }
        public string seat { get; set; }
        public DateTime Purchase_time { get; set; }

    }
}
