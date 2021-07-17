using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using xamarintiklagelsin.Models;
using static System.Net.Mime.MediaTypeNames;

namespace xamarintiklagelsin.Helpers
{
    public class AddRestaurantData
    {
        public List<Restaurant> Restaurants { get; set; }
        FirebaseClient client;
        public AddRestaurantData()
        {
            client = new FirebaseClient("https://xamarintiklagelsin-a4de1-default-rtdb.firebaseio.com/");

            Restaurants = new List<Restaurant>()
                {
                new Restaurant()
                {
                 RestaurantID=1,
                 RestaurantName="Burger King",
                 ImageUrl = "https://d3vkdqr0qjxhag.cloudfront.net/Bk_Logo501x542_4e2be66b64.png"
                 
                },
                new Restaurant()
                {
                 RestaurantID=2,
                 RestaurantName="Popeyes",
                 ImageUrl = "https://d3vkdqr0qjxhag.cloudfront.net/PP_Yazi_Damga_Logo_01_01_de61e369c9.png"
                }

                };
        }

        public async Task AddRestaurantAsync()
        {
            try
            {
                foreach (var restaurant in Restaurants)
                {
                    await client.Child("Restaurants").PostAsync(new Restaurant()
                    {
                        RestaurantID = restaurant.RestaurantID,
                        RestaurantName = restaurant.RestaurantName,
                        ImageUrl = restaurant.ImageUrl

                    });
                }
            }
            catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");

            }
        }

    }
}
