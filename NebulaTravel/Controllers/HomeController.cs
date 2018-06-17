using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NebulaTravel.Data;

namespace NebulaTravel.Controllers
{
    [Route(""), Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private NebulaDbContext context;

        public HomeController(NebulaDbContext context)
        {
            this.context = context;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}