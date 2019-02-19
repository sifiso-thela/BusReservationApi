using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Trip
    {
        public string Id { get; set; }
        public Bus  Bus { get; set; }
        public DateTime Time { get; set; }
        public DateTime Depature_time { get; set; }
        public DateTime Arrival_time { get; set; }
        public string Starting_point { get; set; }
        public string Destination { get; set; }
        public Driver Driver { get; set; }
        public float Price { get; set; }
    }
}
