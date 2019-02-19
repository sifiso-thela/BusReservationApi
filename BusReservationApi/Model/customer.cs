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

        public Customer(string Id, string Name, string Surname, string Phone, string Next_of_kin, string Next_of_kin_number)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Phone = Phone;
            this.Next_of_kin = Next_of_kin;
            this.Next_of_kin_number = Next_of_kin_number;
        }

        public Customer()
        {

        }
    }
}
