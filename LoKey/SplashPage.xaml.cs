using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoKey
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            this.BackgroundColor = Color.FromHex("add8e6");
            //await Navigation.PushAsync(new MainPage());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
