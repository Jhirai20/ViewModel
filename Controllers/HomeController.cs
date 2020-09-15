using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Names()
        {
            //to a VIew that has defined a model
            string[] names = new string[]
            {
                "Sally","Billy","Joey","Moose"  
            };
            return View(names);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
            1,2,3,10,43,5
            };
            return View(numbers);
        }
        public IActionResult UserDetail()
        {
            User SomeUser=new User()
            {
                FirstName="John", LastName="Doe"
            };
            return View(SomeUser);
        }

        public IActionResult Users()
        {
            User User1= new User()
            {
                FirstName="Sally",
                LastName="Sanderson"
            };
            User User2= new User()
            {
                FirstName="Moose",
                LastName="Philips"
            };
            User User3= new User()
            {
                FirstName="Sarah",
                LastName=""
            };
            User User4= new User()
            {
                FirstName="Rene",
                LastName="Ricky"
            };
            List<User> ViewModel = new List<User>()
            {
                User1 ,User2,User3,User4
            };
            return View(ViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
