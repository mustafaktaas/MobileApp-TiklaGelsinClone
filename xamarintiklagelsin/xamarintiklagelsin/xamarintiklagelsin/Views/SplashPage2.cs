using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Emit;
using Xamarin.Forms;

namespace xamarintiklagelsin
{
    public class SplashPage2 : ContentPage
    {
        Image splashImage;

        public SplashPage2()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();

            splashImage = new Image
            {
                Source = "tiklagelsinsplashscreen.png",
                WidthRequest = 350,
                HeightRequest = 350
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#ffffff");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000);
            await splashImage.FadeTo(0, 100, Easing.Linear);
            /*await splashImage.ScaleTo(200, 1200, Easing.Linear);*/
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }


    }
}
