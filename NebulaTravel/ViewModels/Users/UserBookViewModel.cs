using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Users
{
    public class UserBookViewModel
    {
        public Flight Flight { get; set; }
        public bool TicketsAvailable { get; set; } = true;
        public bool IncorrectPassword { get; set; } = false;
    }
}
