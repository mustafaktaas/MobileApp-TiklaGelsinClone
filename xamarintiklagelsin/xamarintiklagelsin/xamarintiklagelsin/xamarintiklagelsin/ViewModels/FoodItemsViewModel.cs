using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using xamarintiklagelsin.Models;
using xamarintiklagelsin.Services;
using Xamarin.Forms;
using System.Threading.Tasks;
using xamarintiklagelsin.Views;

namespace xamarintiklagelsin.ViewModels
{
    public class FoodItemsViewModel : BaseViewModel
    {
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value;
                OnPropertyChanged();
            }
        }

        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            get { return _UserCartItemsCount; }
            set { _UserCartItemsCount = value;
                OnPropertyChanged();
            }
        }

        private string _SearchText;

        public string SearchText
        {
            get { return _SearchText; }
            set { _SearchText = value;
                OnPropertyChanged(); }
        }


        public ObservableCollection<Category> Categories { get; set; }

        public Command ViewCartCommand { get; set; }
        public Command LogoutCommand { get; set; }
        public Command SearchViewCommand { get; set; }


        public FoodItemsViewModel()
        {
            var uname = Preferences.Get("UserName", string.Empty);
            if (String.IsNullOrEmpty(uname))
                UserName = "Guest";
            else
                UserName = uname;

            UserCartItemsCount = new CartItemService().GetUserCartCount();

            Categories = new ObservableCollection<Category>();

            ViewCartCommand = new Command(async () => await ViewCartAsync());
            LogoutCommand = new Command(async () => await LogoutAsync());
            SearchViewCommand = new Command(async () => await SearchViewAsync());

            GetCategories();
        }

        private async Task SearchViewAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new AramaSonuclari(SearchText));
        }

        private async Task LogoutAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Logout());
        }

        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Sepetim());
        }

        private async void GetCategories()
        {
            var data = await new CategoryDataService().GetCategoriesAsync();
            Categories.Clear();
            foreach (var item in data)
            {
                Categories.Add(item);
            }
        }
    }
}
