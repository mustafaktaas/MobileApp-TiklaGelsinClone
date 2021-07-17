using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarintiklagelsin.Models;
using xamarintiklagelsin.ViewModels;

namespace xamarintiklagelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AramaSonuclari : ContentPage
    {
        SearchResultsViewModel srvm;
        public AramaSonuclari(string searchText)
        {       
            InitializeComponent();
            srvm = new SearchResultsViewModel(searchText);
            this.BindingContext = srvm;
        }

        async private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as FoodItem;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductsDetail(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}