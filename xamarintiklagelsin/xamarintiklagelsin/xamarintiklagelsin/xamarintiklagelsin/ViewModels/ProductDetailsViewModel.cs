using System;
using System.Collections.Generic;
using System.Text;
using xamarintiklagelsin.Models;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using xamarintiklagelsin.Views;

namespace xamarintiklagelsin.ViewModels
{
    public class ProductDetailsViewModel : BaseViewModel
    {
        private FoodItem _SelectedFoodItem;

        public FoodItem SelectedFoodItem
        {
            get { return _SelectedFoodItem; }

            set { _SelectedFoodItem = value;
                OnPropertyChanged();
            }
        }

        private int _TotalQuantity;

        public int TotalQuantity
        {
            get { return _TotalQuantity; }

            set
            {
                this._TotalQuantity = value;
                if (this._TotalQuantity < 0)
                    this._TotalQuantity = 0;
                if (this._TotalQuantity > 10)
                    this._TotalQuantity -= 1;
                OnPropertyChanged();

            }
        }

        public Command IncrementOrderCommand { get; set; }
        public Command DecrementOrderCommand { get; set; }
        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }

        public ProductDetailsViewModel(FoodItem foodItem)
        {
            SelectedFoodItem = foodItem;
            TotalQuantity = 0;

            IncrementOrderCommand = new Command(() => IncrementOrder());
            DecrementOrderCommand = new Command(() => DecrementOrder());
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(async () => await ViewCartAsync());
        }

        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Sepetim());
        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductId = SelectedFoodItem.FoodItemID,
                    ProductName = SelectedFoodItem.FoodItemName,
                    Price = SelectedFoodItem.Price,
                    Quantity = TotalQuantity
                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault(c => c.ProductId == SelectedFoodItem.FoodItemID);
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    item.Quantity += TotalQuantity;
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Cart", "Urun Sepete Eklendi", "Ok");
            }
            catch (Exception)
            {
                Application.Current.MainPage.DisplayAlert("Error","Nope","Ok");
            }
            finally
            {
                cn.Close();
            }
        }

        private void DecrementOrder()
        {
            TotalQuantity--;
        }

        private void IncrementOrder()
        {
            TotalQuantity++;
        }
    }
}
