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
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://xamarintiklagelsin-a4de1-default-rtdb.firebaseio.com/");

            Categories = new List<Category>()
                {
                new Category()
                {
                 CategoryID=1,
                 CategoryName="Popular Urunler",
                 RestaurantID=1
                },
                new Category()
                {
                 CategoryID=2,
                 CategoryName="Menuler",
                 RestaurantID=1
                },
                new Category()
                {
                 CategoryID=3,
                 CategoryName="Burgerler",
                 RestaurantID=1
                },
                  new Category()
                {
                 CategoryID=4,
                 CategoryName="Kids Menuler",
                 RestaurantID=1
                },
                    new Category()
                {
                 CategoryID=5,
                 CategoryName="Delight Urunler",
                 RestaurantID=1
                },
                      new Category()
                {
                 CategoryID=6,
                 CategoryName="Cıtır Lezzetler",
                 RestaurantID=1
                },
                        new Category()
                {
                 CategoryID=7,
                 CategoryName="Tatlılar",
                 RestaurantID=1
                },
                          new Category()
                {
                 CategoryID=8,
                 CategoryName="Soslar",
                 RestaurantID=1
                },
                            new Category()
                {
                 CategoryID=9,
                 CategoryName="İçecekler",
                 RestaurantID=1
                }


                };
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        RestaurantID = category.RestaurantID
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
