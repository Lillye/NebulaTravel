using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Users
{
    public class UserFlightEditModel
    {
        public int UserId { get; set; }
        public int FlightId { get; set; }

        public virtual User User { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
