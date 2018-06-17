using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NebulaTravel.Data;

namespace NebulaTravel.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private NebulaDbContext context;

        public UserController(NebulaDbContext context)
        {
            this.context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}