using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

using OdeToFood.Data;
using OdeToFood.Core;
namespace MyApp.Namespace
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantsData restaurantsData;
        [TempData]
        public string DeleteMessage { get; set; }
        public string Message { get; set; }

        public string SearchTerm { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config, IRestaurantsData restaurantsData)
        {
            this.config = config;
            this.restaurantsData = restaurantsData;
        }
        // public void OnGet()
        // {
        //     //this.Message="Hello, world!";
        //     this.Message=config["Message"];
        //     this.Restaurants=restaurantsData.GetAll();
        // }
        public void OnGet(string searchTerm)
        {
            this.SearchTerm = searchTerm;
            //this.Message="Hello, world!";
            this.Message = config["Message"];
            this.Restaurants = restaurantsData.GetRestaurantsByName(searchTerm);
        }
  
    }
}
