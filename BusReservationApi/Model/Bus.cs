using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Bus
    {
        public string id { get; set; }
        public Type Bus_type { get; set; }
        public int Num_seat { get; set; }
    }
}
