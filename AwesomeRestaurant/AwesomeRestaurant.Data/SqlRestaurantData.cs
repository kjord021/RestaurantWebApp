using AwesomeRestaurant.Core;
using AwesomeResturant.AwesomeRestaurant.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeRestaurant.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly AwesomeRestaurantDbContext db;

        public SqlRestaurantData(AwesomeRestaurantDbContext db)
        {
            this.db = db;
        }

        //CRUD operations
        //create
        public Restaurant Add(Restaurant newRestaurant)
        {
            db.Restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        //read
        public Restaurant GetByID(int ID)
        {
            return db.Restaurants.Find(ID);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            var query = from r in db.Restaurants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        //update
        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = db.Restaurants.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }

        //delete
        public Restaurant Delete(int id)
        {
            var restaurant = GetByID(id);

            if (restaurant != null)
            {
                db.Restaurants.Remove(restaurant);
            }

            return restaurant;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
    }
}
