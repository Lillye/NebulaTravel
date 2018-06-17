using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.Models
{
    public class Flight
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto++
        public int FlightId { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Overview { get; set; }
        public string Description { get; set; }
        public int AvailableTickets { get; set; }

        //virtual - lazy loading, change tracking
        public virtual Destination Destination { get; set; } //?
        public virtual Spaceship Spaceship { get; set; }
        public virtual ICollection<UserFlight> UserFlights { get; set; }
    }
}
