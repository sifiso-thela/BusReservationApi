using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Bus
    {
        public string Id { get; set; }
        public string Bus_type { get; set; }
        public int Num_seat { get; set; }
        public string Name { get; set; }
        public string Reg_no { get; set; }
    }
}
