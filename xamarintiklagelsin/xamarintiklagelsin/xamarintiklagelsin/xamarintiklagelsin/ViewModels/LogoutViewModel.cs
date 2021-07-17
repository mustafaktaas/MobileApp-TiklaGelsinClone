using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using xamarintiklagelsin.Services;

namespace xamarintiklagelsin.ViewModels
{
    public class LogoutViewModel : BaseViewModel
    {
        public Command LogoutCommand { get; set; }

        public LogoutViewModel()
        {
            LogoutCommand = new Command(async () => await LogoutUserAsync());
        }

        private async Task LogoutUserAsync()
        {
            var cis = new CartItemService();
            cis.RemoveItemsByCart();
            Preferences.Remove("Username");
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
        }
    }
}
