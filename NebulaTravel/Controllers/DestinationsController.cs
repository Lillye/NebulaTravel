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
            DateTime today = DateTime.Today;
            Destination destination = context.Destinations.FirstOrDefault(d => d.DestinationId == id);
            Flight flight = context.Flights.FirstOrDefault(f => f.Destination == destination && f.Date>=today);
            DestinationsDestinationViewModel model = new DestinationsDestinationViewModel()
            {
                Flight = flight,
                Destination = destination
            };
            return View(model);
        }
    }
}