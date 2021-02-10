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

        //Controller for the index page
        [HttpGet]
        public IActionResult Index()
        {
            //Create a new list of strings to hold the restaurants I created in the restaurant model
            List<string> restaurantList = new List<string>();

            //replace empty values according to the homework guidelines
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                //add a restaurant to the list that can be outputted to the index page
                //It seems like this should work for new lines and tabs, but it doesn't lol.
                    //i'm leaving it in to remind to try to find something that does work
                restaurantList.Add($"#{r.Rank}: {r.Name} ///" +
                    $"\n \t Favorite Dish: {r.FaveDish} ///" +
                    $"\n \t Address: {r.Address} ///" +
                    $"\n \t Phone Number: {r.PhoneNumber} ///" +
                    $"\n \t Link to Website: {r.WebLink} ///");
            }

            //return the index page view and pass the list holding the restaurants i created in the restaurant model.
            return View(restaurantList);
        }

        //controller for the user's suggested restaurants
        public IActionResult TheirRestaurantList()
        {
            //pass in the tempstorage file that is acting as a database and holding user recommendations
            return View(TempStorage.ieTheirRestaurants);
        }

        // get controller for page to submit a new restaurant suggestion
        [HttpGet]
        public IActionResult TheirRestaurantSubmit()
        {
            return View();
        }

        // post controller for page to submit a new restaurant suggestion
        [HttpPost]
        public IActionResult TheirRestaurantSubmit(TheirRestaurantResponse oTheirRestaurantResponse)
        {
            //don't submit the form unless everything has been inputted correctly.
            if (ModelState.IsValid)
            {
                //if correct, add their submission to the temp storage
                TempStorage.AddTheirRestaurant(oTheirRestaurantResponse);
                //send them to the confirmation page and pass the object along
                return View("Confirmation", oTheirRestaurantResponse);
            }
            //if incorrect, just send them the form page again
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
