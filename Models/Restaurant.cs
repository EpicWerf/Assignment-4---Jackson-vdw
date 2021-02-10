using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4___Jackson_vdw.Models
{
    //create necessary fields for the model. 
    //Some fields have been specified as required and have been given to appropriate data annotation
    //fields that aren't required have been given a ? to protect against null values
        //i actually don't think that strings need these but it doesn't hurt to have them I don't think
    //Default values have been added in places they need to be based on the assigment requirements
    public class Restaurant
    {
        //constructor to make rank read only
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        #nullable enable

        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        public string? FaveDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? WebLink { get; set; } = "Coming Soon";

        //create a method that will return a prepopulated list of restaurants when called
        public static Restaurant[] GetRestaurants()
        {
            //all of these create new restaurants that will be passed to a list
            Restaurant r1 = new Restaurant (1)
            {
                //Rank = 1,
                Name = "Panda Express",
                FaveDish = "Orange Chicken",
                Address = "1240 N University Ave, Provo, UT 84604",
                PhoneNumber = "(801) 818-0111",
                WebLink = "www.pandaexpress.com"
            };

            Restaurant r2 = new Restaurant (2)
            {
                //Rank = 2,
                Name = "Sweeto Burrito",
                FaveDish = "The Smokehouse",
                Address = "1284 N University Ave, Provo, UT 84604",
                PhoneNumber = "(801) 373-7000",
                WebLink = "www.sweetoburrito.com"
            };

            Restaurant r3 = new Restaurant (3)
            {
                //Rank = 3,
                Name = "Dirty Bird",
                FaveDish = "Chicken Sandwich",
                Address = "495 E 600 N, Provo, UT 84606",
                PhoneNumber = "(801) 835-9810",
                WebLink = "www.dirtybirdchxx.com"
            };

            Restaurant r4 = new Restaurant (4)
            {
                //Rank = 4,
                Name = "Cafe Rio",
                FaveDish = "Sweet Pork Burrito",
                Address = "2244 N University Pkwy, Provo, UT 84604",
                PhoneNumber = "(801) 375-5133",
                WebLink = "www.caferio.com"
            };

            Restaurant r5 = new Restaurant (5)
            {
                //Rank = 5,
                Name = "P.F. Chang's",
                FaveDish = "Crispy Honey Chicken",
                Address = "575 E University Pkwy., Ste A-20, Orem, UT 84097",
                PhoneNumber = "(801) 426-0900",
                WebLink = "www.pfchangs.com"
            };

            //This last restaurant is just to show that the default values are working
            Restaurant r6 = new Restaurant (6)
            {
                //Rank = 6,
                Name = "Testing Default Values",
                Address = "Testing Default Values",
                PhoneNumber = "Testing Default Values"
            };

            //send the list back to whoever called it.
            return new Restaurant[] { r1, r2, r3, r4, r5, r6 };
        }
    }
}
