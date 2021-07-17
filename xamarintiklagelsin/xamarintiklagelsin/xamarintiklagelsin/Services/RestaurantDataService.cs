using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xamarintiklagelsin.Models;
using System.Text;
using System.Linq;
using Firebase.Database.Query;

namespace xamarintiklagelsin.Services
{
    public class RestaurantDataService
    {
        FirebaseClient client;

        public RestaurantDataService()
        {
            client = new FirebaseClient("https://xamarintiklagelsin-a4de1-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Restaurant>> GetRestaurantsAsync()
        {
            var restaurants = (await client.Child("Categories")
                .OnceAsync<Restaurant>())
                .Select(r => new Restaurant
                {
                   RestaurantID = r.Object.RestaurantID,
                   RestaurantName = r.Object.RestaurantName,
                   ImageUrl = r.Object.ImageUrl
                }
                ).ToList();
            return restaurants;
        }
    }
}
