using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;
using System;

namespace OdeToFood.Data
{
    public class InMemoryRestaurants : IRestaurantsData {
        List<Restaurant> restaurants;
        public InMemoryRestaurants () {
            this.restaurants = new List<Restaurant> () {
                new Restaurant { Id = 1, Name = "Maharaja", Location = "Pune", Cuisine = CuisineType.INDIAN },
                new Restaurant { Id = 2, Name = "Taj", Location = "Mumbai", Cuisine = CuisineType.INDIAN },
                new Restaurant { Id = 3, Name = "Scott's Pizza", Location = "MaryLand", Cuisine = CuisineType.ITALIAN },
                new Restaurant { Id = 4, Name = "La Costa", Location = "California", Cuisine = CuisineType.MEXICAN },
                new Restaurant { Id = 5, Name = "Village", Location = "Pune", Cuisine = CuisineType.INDIAN }
            };
        }
        // public IEnumerable<Restaurant> GetAll () {
        //     return from r in restaurants
        //     orderby r.Name
        //     select r;
        // }
        public IEnumerable<Restaurant> GetRestaurantsByName (string name = null) {
            return from r in restaurants
            where string.IsNullOrEmpty(name) || r.Name.StartsWith(name,StringComparison.OrdinalIgnoreCase)
            orderby r.Name
            select r;
        }

        public Restaurant GetRestaurantById(int id){
            return restaurants.SingleOrDefault(r=>r.Id==id);
        }

        public Restaurant Update(Restaurant updatedRestaurant){
            var restaurant=restaurants.SingleOrDefault(r=>r.Id==updatedRestaurant.Id);
            if(restaurant!=null)
            {
                restaurant.Name=updatedRestaurant.Name;
                restaurant.Location=updatedRestaurant.Location;
                restaurant.Cuisine=updatedRestaurant.Cuisine;
            }
            return restaurant;
        }

        public int commit(){
            return 0;
        }

       public Restaurant Add(Restaurant newRestaurant){
            restaurants.Add(newRestaurant);
            newRestaurant.Id=restaurants.Max(r=>r.Id)+1;
            return newRestaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(r =>r.Id==id);
            if (restaurant != null)
                restaurants.Remove(restaurant);
            return restaurant;
        }
    }
}