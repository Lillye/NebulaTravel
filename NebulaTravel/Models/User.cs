using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaTravel.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto++
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; } // zmiana na email
        public int PasswordHashCode { get; set; }

        public virtual ICollection<UserFlight> UserFlights { get; set; }
    }
}
