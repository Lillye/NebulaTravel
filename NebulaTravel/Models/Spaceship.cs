using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.Models
{
    public class Spaceship
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto++
        public int SpaceshipId { get; set; }

        public string Name { get; set; }
        public string Picture { get; set; }
        public string Overview { get; set; }
        public string Description { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
