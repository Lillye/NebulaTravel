using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Flights
{
    public class FlightsFlightViewModel
    {
        public Flight Flight { get; set; }
        public bool IsHistorical { get; set; }
        public bool TicketsAvailable { get; set; }
    }
}
