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
        #nullable enable
        [Required] 
        public int Rank { get; set; }

        [Required]
        public string? Name { get; set; }

        //Favorite Dish and Phone number are optional, so put a ? to protect the program from breaking if the user inputs nothing
        public string? FaveDish { get; set; }

        //check to make sure phone number is in valid format
        [RegularExpression(@"\d{3}-\d{3}-\d{4}$",
         ErrorMessage = "Phone number must be in valid format: XXX-XXX-XXXX.")]
        public string? PhoneNumber { get; set; }
    }
}
