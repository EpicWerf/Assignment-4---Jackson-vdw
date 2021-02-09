using Assignment_4___Jackson_vdw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4___Jackson_vdw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {

            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                if (string.IsNullOrEmpty(r.FaveDish))
                {
                    r.FaveDish = "It's all tasty!";
                }
                if (string.IsNullOrEmpty(r.WebLink))
                {
                    r.WebLink = "Coming soon.";
                }
                restaurantList.Add($"#{r.Rank}: {r.Name} " +
                    $"\n \t Favorite Dish: {r.FaveDish}" +
                    $"\n \t Address: {r.Address}" +
                    $"\n \t Phone Number: {r.PhoneNumber}" +
                    $"\n \t Link to Website: {r.WebLink}");
            }
            return View(restaurantList);
            //return View();
        }

        [HttpGet]
        public IActionResult TheirRestaurantList()
        {
            //List<string> restaurantList = new List<string>();

            //foreach (Restaurant r in Restaurant.GetRestaurants())
            //{
            //    if (string.IsNullOrEmpty(r.FaveDish))
            //    {
            //        r.FaveDish = "It's all tasty!";
            //    }
            //    if (string.IsNullOrEmpty(r.WebLink))
            //    {
            //        r.WebLink = "Coming soon.";
            //    }
            //    restaurantList.Add($"#{r.Rank}: {r.Name} " +
            //        $"\n \t Favorite Dish: {r.FaveDish}" +
            //        $"\n \t Address: {r.Address}" +
            //        $"\n \t Phone Number: {r.PhoneNumber}" +
            //        $"\n \t Link to Website: {r.WebLink}");
            //}
            //return View("RestaurantList", restaurantList);
            return View();
        }

        [HttpGet]
        public IActionResult TheirRestaurantSubmit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TheirRestaurantSubmit(TheirRestaurantResponse oTheirRestaurantResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddTheirRestaurant(oTheirRestaurantResponse);
                return View("Confirmation", oTheirRestaurantResponse);
            }
            return View();

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
