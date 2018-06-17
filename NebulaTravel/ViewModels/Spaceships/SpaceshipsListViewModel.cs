using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Spaceships
{
    public class SpaceshipsListViewModel
    {
        public IEnumerable<Spaceship> Spaceships { get; set; }
    }
}
