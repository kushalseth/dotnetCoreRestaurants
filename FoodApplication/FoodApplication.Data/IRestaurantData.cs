using FoodApplication.Core;
using System;
using System.Collections.Generic;

namespace FoodApplication.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
}
