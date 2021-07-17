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
    public partial class SiparisSanaGelsin : ContentPage
    {
        public SiparisSanaGelsin(string id)
        {
            InitializeComponent();
                    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SiparisGecmisi());
        }
    }
}