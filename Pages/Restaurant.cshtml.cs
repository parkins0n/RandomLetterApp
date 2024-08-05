using Microsoft.AspNetCore.Mvc.RazorPages;
using RandomLetterApp.Models;
using System.Collections.Generic;

namespace RandomLetterApp.Pages
{
    public class RestaurantModel : PageModel
    {
        public List<Restaurant> Restaurants { get; set; }

        public void OnGet()
        {
            Restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Ресторан A", Address = "Адрес A", Cuisine = "Кухня A" },
                new Restaurant { Id = 2, Name = "Ресторан B", Address = "Адрес B", Cuisine = "Кухня B" },
                new Restaurant { Id = 3, Name = "Ресторан C", Address = "Адрес C", Cuisine = "Кухня C" }
            };
        }
    }
}