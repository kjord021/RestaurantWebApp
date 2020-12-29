using AwesomeRestaurant.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AwesomeRestaurant.Data
{
    public interface IRestaurantData
    {

        IEnumerable<Restaurant> GetAll();

    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        //Create temp data for dev
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { ID = 1,
                Name = "Scott's Pizza",
                Location = "Brandon",
                Cuisine = CuisineType.Italian},
                new Restaurant { ID = 2,
                Name = "Kyle's Pizza",
                Location = "Tampa",
                Cuisine = CuisineType.Italian},
                new Restaurant { ID = 3,
                Name = "Dos Amigos",
                Location = "Riverview",
                Cuisine = CuisineType.Mexican},
                new Restaurant { ID = 4,
                Name = "Taj Ma-Haven",
                Location = "Apollo Beach",
                Cuisine = CuisineType.Indian}
            };
        }

        //Return all restaurants
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    
    }
}
