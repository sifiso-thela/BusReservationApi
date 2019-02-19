using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationApi.Model
{
    public class Rental
    {
        public Customer Customer { get; set; }
        public string id { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int number_of_days { get; set; }
        public Driver Driver { get; set; }
        public Agent Agent { get; set; }
    }
}
