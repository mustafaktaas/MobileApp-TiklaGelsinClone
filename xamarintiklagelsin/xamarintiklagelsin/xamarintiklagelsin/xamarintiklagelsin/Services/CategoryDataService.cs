using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xamarintiklagelsin.Models;
using System.Text;
using System.Linq;
using Firebase.Database.Query;
using System.Collections.ObjectModel;

namespace xamarintiklagelsin.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;

        public CategoryDataService()
        {
            client = new FirebaseClient("https://xamarintiklagelsin-a4de1-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName
                }
                ).ToList();
            return categories;
        }

        public async Task<ObservableCollection<Category>> GetCategoryByRestaurantAsync(int restaurantID)
        {
            var categoriesByRestaurant = new ObservableCollection<Category>();
            var items = (await GetCategoriesAsync()).Where(p => p.RestaurantID == restaurantID).ToList();
            foreach (var item in items)
            {
                categoriesByRestaurant.Add(item);
            }
            return categoriesByRestaurant;
        }
    }


}
