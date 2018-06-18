using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NebulaTravel.Data;
using NebulaTravel.Models;
using NebulaTravel.ViewModels.Users;

namespace NebulaTravel.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        // zrobić to porządnie z przykładu na asp.net core user authentication a nie tak 

        private NebulaDbContext context;
        private UserManager manager;

        public UserController(NebulaDbContext context, UserManager manager)
        {
            this.context = context;
            this.manager = manager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLoginEditModel model)
        {
            if (ModelState.IsValid)
            {
                User user = context.Users.FirstOrDefault(u => u.Login == model.Email && u.PasswordHashCode == model.Password.GetHashCode());
                if (user != null)
                {
                    manager.SignIn(this.HttpContext, user);
                }
                return RedirectToAction("Index", "Home");
            }
            else
                return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegisterEditModel model)
        {
            if (ModelState.IsValid)
            {
                var names = model.FullName.Split(" ");
                User newUser = new User()
                {
                    FirstName = names[0],
                    LastName = names[1],
                    Login = model.Email, // do zmiany na email w bazie danych
                    PasswordHashCode = model.Password.GetHashCode() // w praktyce używa się znacznie bardziej rozbudowanych hashowań - zmienić
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            else
                return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Book(int id)
        {
            Flight model = context.Flights.FirstOrDefault(f => f.FlightId == id);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Book(UserFlightEditModel model)
        {
            if (ModelState.IsValid)
            {
                UserFlight newUserFlight = new UserFlight()
                {
                    UserId = model.UserId,
                    FlightId = model.FlightId,
                    User = model.User,
                    Flight = model.Flight
                };
                context.UserFlights.Add(newUserFlight);
                context.SaveChanges();
                return RedirectToAction("Flight","Flights", new { id = model.FlightId });
            }
            else
                return View();
        }
    }
}