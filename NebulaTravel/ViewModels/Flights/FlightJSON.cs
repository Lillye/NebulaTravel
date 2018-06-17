using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Flights
{
    public class FlightJSON
    {
        public int FlightId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string AvailableTickets { get; set; }
        public string Picture { get; set; }
        public string Overview { get; set; }
    }
}
