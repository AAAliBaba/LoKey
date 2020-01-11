using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoKey
{
    public partial class App : Application
    {
        public static Keychain keychain = new Keychain("Sami Beig");

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage( new SplashPage() );
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
