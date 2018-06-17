using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NebulaTravel.Data;
using NebulaTravel.Models;
using NebulaTravel.ViewModels.Flights;

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
            //DateTime today = DateTime.Today; //uzwględnić strefy czasowe
            IEnumerable<Flight> flights = from f in context.Flights
                                          select f;
            List < FlightJSON > json = new List<FlightJSON>();
            foreach (var flight in flights)
            {
                // wyliczanie stanu powinno odbywać się z na podstawie sprawdzenia liczby miejsc dostępnych na statku powiązanym z lotem
                string availableTickets = "low";
                if (flight.AvailableTickets >= 50)
                {
                    availableTickets = "medium";
                }
                if(flight.AvailableTickets >= 150)
                {
                    availableTickets = "high";
                }
                FlightJSON entry = new FlightJSON()
                {
                    FlightId = flight.FlightId,
                    Name = flight.Name,
                    Date = flight.Date.Date.ToShortDateString(), // w szczegółach lotu też czas
                    Picture = "/images/n1.jpg", //do zmiany
                    AvailableTickets = availableTickets,
                    Overview = flight.Overview
                };
                json.Add(entry);
            }
            return Json(json); //new {a="aa", b="bb"}
        }

        public IActionResult Flight(int id)
        {
            bool isHistorical = false;
            bool ticketsAvailable = true;
            DateTime today = DateTime.Today;
            Flight flight = context.Flights.FirstOrDefault(d => d.FlightId == id);
            if (flight.Date < today)
            {
                isHistorical = true;
                ticketsAvailable = false;
            }
            if (!isHistorical && flight.AvailableTickets == 0)
            {
                ticketsAvailable = false;
            }
            FlightsFlightViewModel model = new FlightsFlightViewModel()
            {
                Flight = context.Flights.FirstOrDefault(d => d.FlightId == id),
                IsHistorical = isHistorical,
                TicketsAvailable = ticketsAvailable
            };
            return View(model);
        }
    }
}

