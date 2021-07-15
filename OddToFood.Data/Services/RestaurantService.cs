using OddToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddToFood.Data
{
    public class RestaurantService : IRestaurantService
    {
        List<Restaurant> RestourantList = new List<Restaurant>()
        {
           new Restaurant {Id = 1, Name = "BurgerKing", KitchenType = Restaurant.Kitchen.American},
           new Restaurant {Id = 2, Name = "Sbarro", KitchenType = Restaurant.Kitchen.Maxican},
           new Restaurant {Id = 3, Name = "Bereket", KitchenType = Restaurant.Kitchen.Italian}
        };

        public List<Restaurant> getAll()
        {
            var result = RestourantList.OrderBy(x=>x.Name).ToList();

            return result;
        }
    }
}
