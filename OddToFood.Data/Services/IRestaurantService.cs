using OddToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OddToFood.Data
{
    public interface IRestaurantService
    {
        List<Restaurant> getAll();
    }
}
