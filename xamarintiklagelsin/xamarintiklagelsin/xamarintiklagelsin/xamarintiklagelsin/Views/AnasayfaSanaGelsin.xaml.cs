using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarintiklagelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnasayfaSanaGelsin : ContentPage
    {
        public AnasayfaSanaGelsin()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ChooseOrderPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Categories());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sepetim());
        }
    }
}