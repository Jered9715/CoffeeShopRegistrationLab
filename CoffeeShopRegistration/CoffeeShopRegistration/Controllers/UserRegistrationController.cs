using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class UserRegistrationController : Controller
    {
        static List<User> _users = new List<User>
        {
            new User
            {
            Id = 1,
            FirstName = "Jered",
            LastName = "OGrady",
            Email = "Jered9715@gmail.com",
            BirthDate = DateTime.Parse("1997-02-03"),
            Password = "123Password"
            }

        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(_users);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        
        
        [HttpPost]
        public IActionResult Registration(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = _users.Max(x => x.Id) + 1;
                _users.Add(user);

                return RedirectToAction("Summary",user);
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Summary(User user)
        {
            return View(user);
        
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return View(user);
        
        }

    }
}
