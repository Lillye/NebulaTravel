using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
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
        public IActionResult Login(UserLoginEditModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User user = context.Users.FirstOrDefault(u => u.Login == model.Email);
                string[] parts = new string[2];
                parts = user.PasswordHashCode.Split(" : ");
                string salt = parts[0];
                string password = parts[1];
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: model.Password,
                    salt: Encoding.BigEndianUnicode.GetBytes(salt),
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));

                if (password.Equals(hashed))
                {
                    manager.SignIn(this.HttpContext, user);
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            else
                return View();
        }

        public IActionResult Logout()
        {
            manager.SignOut(this.HttpContext);
            return Redirect(Request.Headers["Referer"]);
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

                // generate a 128-bit salt using a secure PRNG
                byte[] salt = new byte[128 / 8];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }


                // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: model.Password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));

                User newUser = new User()
                {
                    FirstName = names[0],
                    LastName = names[1],
                    Login = model.Email, // do zmiany na email w bazie danych
                    PasswordHashCode = Encoding.BigEndianUnicode.GetString(salt) + " : " + hashed // w praktyce używa się znacznie bardziej rozbudowanych hashowań - zmienić
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
                if (context.Users.FirstOrDefault(u => u.PasswordHashCode == model.Password) != null)
                {
                    var flight = context.Flights.FirstOrDefault(f => f.FlightId == model.Id);
                    var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    var user = context.Users.FirstOrDefault(u => u.UserId == userId);
                    UserFlight newUserFlight = new UserFlight()
                    {
                        UserId = userId,
                        FlightId = model.Id,
                        User = user,
                        Flight = flight
                    };
                    context.UserFlights.Add(newUserFlight);
                    context.SaveChanges();
                    return RedirectToAction("Flight", "Flights", new { id = model.Id });
                }
                return View();
            }
            else
                return View();
        }
    }
}