using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarintiklagelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sepetim : ContentPage
    {
        public Sepetim()
        {
            InitializeComponent();
           // LabelName.Text = "Welcome" + Preferences.Get("Username", "Guest") + ",";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PopModalAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync( new KartlaOde());
        }
    }
}