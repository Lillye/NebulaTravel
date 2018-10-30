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
        public string Length { get; set; }
        public string TotalMass { get; set; }
        public int CrewCapacity { get; set; }
        public int PassengerCapacity { get; set; }
        public string Engines { get; set; }
        public string Constructor { get; set; }
        public DateTime FirstLaunch { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
