using System;
using System.Collections.Generic;
using System.Text;
using xamarintiklagelsin.Models;
using System.Collections.ObjectModel;
using xamarintiklagelsin.ViewModels;
using xamarintiklagelsin.Services;

namespace xamarintiklagelsin.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        private Category _SelectedCategory;

        public Category SelectedCategory
        {
            get {
                return _SelectedCategory; 
            }
            set { 
                _SelectedCategory = value;
                OnPropertyChanged(); 
            }
        }

        public ObservableCollection<FoodItem> FoodItemsByCategory { get; set; }

        private int _TotalFoodItems;

        public int TotalFoodItems
        {
            get
            {
                return _TotalFoodItems;
            }
            set
            {
                _TotalFoodItems = value;
                OnPropertyChanged();
            }
        }

       public CategoryViewModel(Category category)
        {
            SelectedCategory = category;
            FoodItemsByCategory = new ObservableCollection<FoodItem>();
            GetFoodItems(category.CategoryID);
        }

        private async void GetFoodItems(int categoryID)
        {
            var data = await new FoodItemService().GetFoodItemsByCategoryAsync(categoryID);
            FoodItemsByCategory.Clear();
            foreach (var item in data)
            {
                FoodItemsByCategory.Add(item);
            }
            TotalFoodItems = FoodItemsByCategory.Count;
        }
    }
}
