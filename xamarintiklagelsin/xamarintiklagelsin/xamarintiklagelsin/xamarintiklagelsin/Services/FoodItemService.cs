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
    public class FoodItemService
    {
        FirebaseClient client;

        public FoodItemService()
        {
            client = new FirebaseClient("https://xamarintiklagelsin-a4de1-default-rtdb.firebaseio.com/");
        }

        public async Task<List<FoodItem>> GetFoodItemsAsync()
        {
            var fooditems = (await client.Child("FoodItems")
                .OnceAsync<FoodItem>())
                .Select(f => new FoodItem
                {
                    CategoryID = f.Object.CategoryID,
                    FoodItemID = f.Object.FoodItemID,
                    FoodItemName = f.Object.FoodItemName,
                    Price = f.Object.Price,
                    ImageUrl=f.Object.ImageUrl,
                    Rating = f.Object.Rating
                }
                ).ToList();
            return fooditems;
        }

        public async Task<ObservableCollection<FoodItem>> GetFoodItemsByCategoryAsync(int categoryID)
        {
            var foodItemsByCategory = new ObservableCollection<FoodItem>();
            var items = (await GetFoodItemsAsync()).Where(p => p.CategoryID == categoryID).ToList();
            foreach (var item in items)
            {
                foodItemsByCategory.Add(item);
            }
            return foodItemsByCategory;
        }

        public async Task<ObservableCollection<FoodItem>> GetFoodItemsByQueryAsync(string searchText)
        {
            var foodItemsByQuery = new ObservableCollection<FoodItem>();
            var items = (await GetFoodItemsAsync()).
                Where(p => p.FoodItemName.Contains(searchText)).ToList();
            foreach (var item in items)
            {
                foodItemsByQuery.Add(item);

            }

            return foodItemsByQuery;
        }

    }
}
