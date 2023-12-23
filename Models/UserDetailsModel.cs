using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class UserDetailsModel
    {
        public string Username { get; set; }
        public string Eventname { get; set; }
        public string Venuename { get; set; }
        public string VenueAddress { get; set; }
        public string City { get; set; }
        public int NumberOfSeats { get; set; }
        public string TicketType { get; set; }
        public decimal TotalPrice { get; set; }

    }
}