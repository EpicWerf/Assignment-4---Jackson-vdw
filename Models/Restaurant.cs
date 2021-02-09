using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4___Jackson_vdw.Models
{
    public class Restaurant
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string FaveDish { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string WebLink { get; set; }


        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant
            {
                Rank = 1,
                Name = "Panda Express",
                FaveDish = "Orange Chicken",
                Address = "1240 N University Ave, Provo, UT 84604",
                PhoneNumber = "(801) 818-0111",
                WebLink = "www.pandaexpress.com"
            };

            Restaurant r2 = new Restaurant
            {
                Rank = 2,
                Name = "Sweeto Burrito",
                FaveDish = "The Smokehouse",
                Address = "1284 N University Ave, Provo, UT 84604",
                PhoneNumber = "(801) 373-7000",
                WebLink = "www.sweetoburrito.com"
            };

            Restaurant r3 = new Restaurant
            {
                Rank = 3,
                Name = "Dirty Bird",
                FaveDish = "Chicken Sandwich",
                Address = "495 E 600 N, Provo, UT 84606",
                PhoneNumber = "(801) 835-9810",
                WebLink = "www.dirtybirdchxx.com"
            };

            Restaurant r4 = new Restaurant
            {
                Rank = 4,
                Name = "Cafe Rio",
                FaveDish = "Sweet Pork Burrito",
                Address = "2244 N University Pkwy, Provo, UT 84604",
                PhoneNumber = "(801) 375-5133",
                WebLink = "www.caferio.com"
            };

            Restaurant r5 = new Restaurant
            {
                Rank = 5,
                Name = "P.F. Chang's",
                FaveDish = "Crispy Honey Chicken",
                Address = "575 E University Pkwy., Ste A-20, Orem, UT 84097",
                PhoneNumber = "(801) 426-0900",
                WebLink = "www.pfchangs.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
