using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Next_of_kin { get; set; }
        public string Next_of_kin_number { get; set; }
    }
}
