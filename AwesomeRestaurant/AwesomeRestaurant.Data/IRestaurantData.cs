using AwesomeRestaurant.Core;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRestaurant.Data
{
    public interface IRestaurantData
    {

        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetByID(int ID);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int Commit();
    }
}
