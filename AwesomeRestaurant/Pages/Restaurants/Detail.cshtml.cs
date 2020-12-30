using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeRestaurant.Core;
using AwesomeRestaurant.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AwesomeResturant.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData restaurantData;
        public Restaurant Restaurant { get; set; }

        //There is no reference needed to where this is created
        //That is because ASP.NET searched the data structure 
        //In memory to find any instance of tempdata that matches
        [TempData]
        public string Message { get; set; }

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaurantID)
        {
            Restaurant = restaurantData.GetByID(restaurantID);
            
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
