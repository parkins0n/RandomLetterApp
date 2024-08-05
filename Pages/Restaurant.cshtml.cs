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
                new Restaurant { Id = 1, Name = "�������� A", Address = "����� A", Cuisine = "����� A" },
                new Restaurant { Id = 2, Name = "�������� B", Address = "����� B", Cuisine = "����� B" },
                new Restaurant { Id = 3, Name = "�������� C", Address = "����� C", Cuisine = "����� C" }
            };
        }
    }
}