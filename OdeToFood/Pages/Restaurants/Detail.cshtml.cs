using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace MyApp.Namespace
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantsData restaurantData;
        [TempData]
        public string Message { get; set; }
        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantsData restaurantData)
        {
            this.restaurantData=restaurantData;
        }
        public IActionResult OnGet( int restaurantId)
        {
            Restaurant=restaurantData.GetRestaurantById(restaurantId);
            if(Restaurant==null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
