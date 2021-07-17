using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarintiklagelsin.Views;

namespace xamarintiklagelsin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();

            string uname = Preferences.Get("UserName", String.Empty);

            if (String.IsNullOrEmpty(uname))
            {
                Navigation.PushModalAsync(new LoginPage());
            }
            else
            {
                Navigation.PushModalAsync(new ChooseOrderPage());
            }
        }


       // Navigation.PushAsync(new LoginPage());
    }
}