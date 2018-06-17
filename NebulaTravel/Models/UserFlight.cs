using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.Models
{
    public class UserFlight
    {
        public int UserId { get; set; }
        public int FlightId { get; set; }

        public virtual User User { get; set; }
        public virtual Flight Flight { get; set; }

        //future extra info
    }
}
