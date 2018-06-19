using NebulaTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.ViewModels.Users
{
    public class UserRegisterEditModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
    }
}
