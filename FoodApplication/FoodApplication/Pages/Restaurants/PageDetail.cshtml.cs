using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApplication.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace FoodApplication.Pages.Restaurants
{
    public class PageDetailModel : PageModel
    {
        private readonly IConfiguration config;

        public PageDetailModel(IConfiguration config)
        {
            this.config = config;
            Restaurant = new Restaurant();
        }

        public Restaurant Restaurant { get; set; }
        public string Message { get; set; }

        // strict input model, so we are not making a Public property
        public void OnGet(int restaurantId)
        {
            Restaurant.Id = restaurantId;
            Message = config["Message"];
        }
    }
}