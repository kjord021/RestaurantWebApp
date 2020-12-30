using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeRestaurant.Core;
using AwesomeRestaurant.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AwesomeResturant.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData restaurantData;
        private readonly IHtmlHelper htmlHelper;
        
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }

        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelper)
        {
            this.restaurantData = restaurantData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? restaurantID)
        {
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();

            //if restaurant has id get by id
            if (restaurantID.HasValue)
            {
                Restaurant = restaurantData.GetByID(restaurantID.Value);
            }
            //else create a new restaurant
            else
            {
                Restaurant = new Restaurant();
            }

            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound"); 
            }
            return Page();
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                return Page();
            }

            if (Restaurant.ID > 0)
            {
                restaurantData.Update(Restaurant);
            }
            else
            {
                restaurantData.Add(Restaurant);
            }
          
            restaurantData.Commit();

            //TempData is a data structure, used like a dictionary 
            //created to store temporary data
            TempData["Message"] = "Restaurant Saved!";

            //the second parameter passed the ID of the current restaurant
            //to the page to get the correct page by ID
            return RedirectToPage("./Detail", new { restaurantID = Restaurant.ID });


        }
    }
}
