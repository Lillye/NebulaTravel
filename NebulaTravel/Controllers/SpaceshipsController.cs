using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NebulaTravel.Data;
using NebulaTravel.Models;
using NebulaTravel.ViewModels.Spaceships;

namespace NebulaTravel.Controllers
{
    [Route("[controller]/[action]")]
    public class SpaceshipsController : Controller
    {
        private NebulaDbContext context;

        public SpaceshipsController(NebulaDbContext context)
        {
            this.context = context;
        }

        public IActionResult List()
        {
            SpaceshipsListViewModel model = new SpaceshipsListViewModel()
            {
                Spaceships = context.Spaceships.OrderBy(d => d.SpaceshipId)
            };
            return View(model);
        }

        public IActionResult Spaceship(int id)
        {
            Spaceship model = context.Spaceships.FirstOrDefault(d => d.SpaceshipId == id);
            return View(model);
        }
    }
}