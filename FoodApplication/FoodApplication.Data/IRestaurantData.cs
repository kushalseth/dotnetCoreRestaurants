using FoodApplication.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodApplication.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location="Maryland", CuisineType=CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Cinnamon Club", Location="London", CuisineType=CuisineType.Italian},
                new Restaurant { Id = 3, Name = "La Costa", Location = "California", CuisineType=CuisineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
