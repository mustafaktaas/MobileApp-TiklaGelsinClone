using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarintiklagelsin.Services;
using Xamarin.Essentials;
using xamarintiklagelsin.Views;

namespace xamarintiklagelsin.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private int _PhoneNo;
        public int PhoneNo
        {
            set
            {
                this._PhoneNo = value;
                OnPropertyChanged();
            }
            get
            {
                return this._PhoneNo;
            }
        }

        private string _Ad;
        public string Ad
        {
            set
            {
                this._Ad = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Ad;
            }
        }

        private string _Soyad;
        public string Soyad
        {
            set
            {
                this._Soyad = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Soyad;
            }
        }

        private string _EMail;
        public string EMail
        {
            set
            {
                this._EMail = value;
                OnPropertyChanged();
            }
            get
            {
                return this._EMail;
            }
        }

        private string _Username;
        public string Username
        {
            set
            {
                this._Username = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Username;
            }
        }

        private string _Password;
        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Password;
            }
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
            get
            {
                return this._IsBusy;
            }
        }

        private bool _Result;
        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Result;
            }
        }


        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(Username, Password , Ad , Soyad, EMail , PhoneNo );
                if (Result)
                {
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
                await Application.Current.MainPage.DisplayAlert("Başarılı", "Kullanıcı Kaydedildi", "OK");
                }                  
                else
                    await Application.Current.MainPage.DisplayAlert("Error", "Bu Bilgilere Sahip Kullanıcı Mevcut", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.LoginUser(Username, Password);
                if (Result)
                {
                    Preferences.Set("Username", Username);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new ChooseOrderPage());
                }
                else
                    await Application.Current.MainPage.DisplayAlert("Hata", "Girdiğiniz Kullanıcı Adı veya Şifre Yanlış", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
