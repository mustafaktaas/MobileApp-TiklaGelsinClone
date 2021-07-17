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
    public partial class AddAdressPage : ContentPage
    {
        public AddAdressPage()
        {
            InitializeComponent();
           
            
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.White;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Red;
        }


        private void Btn_Adres_Kyt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddSettingsPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ChooseOrderPage());
        }
    }
}