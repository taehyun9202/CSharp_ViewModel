using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string welcome = "This is a Model fun!";
            return View("Index",welcome);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User Tyler = new User(){name = "Tyler"};
            User Royce = new User(){name = "Royce"};
            User Lena = new User(){name = "Lena"};
            User April = new User(){name = "April"};
            List<User> user = new List<User>(){Tyler, Royce, Lena, April};
            return View("Users",user);
        }
        [HttpGet("user")]
        public IActionResult AUser()
        {
            User Tyler = new User(){name = "Tyler"};
            User Royce = new User(){name = "Royce"};
            User Lena = new User(){name = "Lena"};
            User April = new User(){name = "April"};
            List<User> user = new List<User>(){Tyler, Royce, Lena, April};
            Random ran = new Random();
            int number= ran.Next(0, 3);
            return View("User",user[number]);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] Numbers = new int[10];
            for( int i = 0; i < Numbers.Length; i ++)
            {
                Random ran = new Random();
                int number = ran.Next(0, 100);
                Numbers[i] = number;
            }
            return View("Numbers",Numbers);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
