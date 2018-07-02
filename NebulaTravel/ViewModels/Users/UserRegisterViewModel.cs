using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Users
{
    public class UserRegisterViewModel
    {
        public User User { get; set; }
        public bool EmailAvailable { get; set; }
    }
}
