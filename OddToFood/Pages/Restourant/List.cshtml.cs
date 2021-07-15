using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OddToFood.Data;
using OddToFood.Core;
using OddToFood.Data.Services;

namespace OddToFood.Pages
{
    public class ListModel : PageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string msg { get; set; }

        public List<Restaurant> Restaurants { get; set; } 
        public List<Customer> Customers { get; set; }
        public List<Button> Buttons { get; set; }

        private readonly IConfiguration config;
        private readonly IRestaurantService restaurantService;
        private readonly ICustomerService customerService;
        private readonly IButtonService buttonService;

        public ListModel(IConfiguration config,
            IRestaurantService restaurantService,
            ICustomerService customerService,
            IButtonService buttonService)
        {
            this.config = config;
            this.restaurantService = restaurantService;
            this.customerService = customerService;
            this.buttonService = buttonService;
        }

        public void OnGet()
        {
            this.Name = "BurgerKing";
            this.msg = config.GetSection("h_2").Value;
            this.Restaurants = restaurantService.getAll();
            this.Customers = customerService.getAll();
            this.Buttons = buttonService.getAll();
        }


    }
}
