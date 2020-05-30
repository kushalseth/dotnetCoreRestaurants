using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace FoodApplication.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        // set config into a private field
        private readonly IConfiguration config;

        

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }

        public string Message { get; set; }
        public void OnGet()
        {
            //Message = "Hello World";
            Message = config["Message"];
        }
    }
}