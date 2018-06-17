using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NebulaTravel.Data;

namespace NebulaTravel.Controllers
{
    [Route("[controller]/[action]")]
    public class FlightsController : Controller
    {
        private NebulaDbContext context;

        public FlightsController(NebulaDbContext context)
        {
            this.context = context;
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult Data()
        {
            return Json(new {a="aa", b="bb"});
        }

        public IActionResult Flight(int id)
        {
            return View(id);
        }
    }
}

