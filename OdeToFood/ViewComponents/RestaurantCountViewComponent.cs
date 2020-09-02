using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OdeToFood.ViewComponents
{
    public class RestaurantCountViewComponent : ViewComponent
    {
        private readonly IRestaurantsData restaurantsData;

        public RestaurantCountViewComponent(IRestaurantsData restaurantsData)
        {
            this.restaurantsData = restaurantsData;
        }

        public IViewComponentResult Invoke()
        {
            var count = restaurantsData.GetRestaurantsCount();
            return View(count);//View("pname",count);bydefault name will default
        }
    }
}
