using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantsData {
       // IEnumerable<Restaurant> GetAll ()
        IEnumerable<Restaurant> GetRestaurantsByName (string name);
        Restaurant GetRestaurantById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int commit();

    }
}