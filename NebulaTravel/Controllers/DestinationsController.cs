using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NebulaTravel.Data;
using NebulaTravel.Models;
using NebulaTravel.ViewModels.Destinations;

namespace NebulaTravel.Controllers
{
    [Route("[controller]/[action]")]
    public class DestinationsController : Controller
    {
        private NebulaDbContext context;

        public DestinationsController(NebulaDbContext context)
        {
            this.context = context;
        }

        public IActionResult List()
        {
            DestinationsListViewModel model = new DestinationsListViewModel()
            {
                Destinations = context.Destinations.OrderBy(d => d.DestinationId)
            };
            return View(model);
        }

        public IActionResult Destination(int id)
        {
            Destination model = context.Destinations.FirstOrDefault(d => d.DestinationId == id);
            return View(model);
        }
    }
}