using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using xamarintiklagelsin.Models;
using xamarintiklagelsin.Services;

namespace xamarintiklagelsin.ViewModels
{
    public class SearchResultsViewModel : BaseViewModel
    {
        public ObservableCollection<FoodItem> FoodItemsByQuery { get; set; }

        private int _TotalFoodItems;

        public int TotalFoodItems
        {
            get { return _TotalFoodItems; }
            set
            {
                _TotalFoodItems = value;
                OnPropertyChanged();
            }
        }
       
        public SearchResultsViewModel(string searchText)
        {
            FoodItemsByQuery = new ObservableCollection<FoodItem>();
            GetFoodItemsByQueryAsync(searchText);
        }

        private async void GetFoodItemsByQueryAsync(string searchText)
        {
            var data = await new FoodItemService().GetFoodItemsByQueryAsync(searchText);
            FoodItemsByQuery.Clear();
            foreach (var item in data)
            {
                FoodItemsByQuery.Add(item);
            }
            TotalFoodItems = FoodItemsByQuery.Count;
        }
    }
}
