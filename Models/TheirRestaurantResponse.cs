using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4___Jackson_vdw.Models
{
    //create a model that will be used whenever a user submits a restaurant recommendation
    public class TheirRestaurantResponse
    {
        [Required]
        public string Rank { get; set; }
        [Required]
        public string Name { get; set; }
        public string FaveDish { get; set; }
        [Required][Phone]
        public string PhoneNumber { get; set; }
    }
}
