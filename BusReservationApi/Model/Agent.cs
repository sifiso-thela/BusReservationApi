using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Agent 
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
