using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Destinations
{
    public class DestinationsListViewModel
    {
        public IEnumerable<Destination> Destinations { get; set; }
    }
}
