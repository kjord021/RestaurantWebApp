using AwesomeRestaurant.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AwesomeRestaurant.Data
{
    public interface IRestaurantData
    {

        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetByID(int ID);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        int Commit();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        //Create list to store restaurants
        List<Restaurant> restaurants;

        //create temp data in memory
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
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        //Return a restaurant with updated values
        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.ID == updatedRestaurant.ID);

            if (restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }

            return restaurant;

        }

        //Return a new restaurant entity with new values
        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.ID = restaurants.Max(r => r.ID) + 1;
            return newRestaurant;
        }

        //return a restaurant by id
        public Restaurant GetByID(int ID) 
        {
            return restaurants.SingleOrDefault(r => r.ID == ID);
        }

        public int Commit()
        {
            return 0;
        }
    }
}
