using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4___Jackson_vdw.Models
{
    public class TempStorage
    {
        private static List<TheirRestaurantResponse> lTheirRestaurants = new List<TheirRestaurantResponse>();

        public static IEnumerable<TheirRestaurantResponse> ieTheirRestaurants => lTheirRestaurants;

        public static void AddTheirRestaurant(TheirRestaurantResponse oTheirRestaurant)
        {
            lTheirRestaurants.Add(oTheirRestaurant);
        }
    }
}
