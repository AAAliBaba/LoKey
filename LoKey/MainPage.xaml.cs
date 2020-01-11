using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Fingerprint;


namespace LoKey
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            UseFingerprint();
        }

        private async void UseFingerprint()
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync(true);
            if (result)
            {
                var auth = await CrossFingerprint.Current.AuthenticateAsync("Authenticate?");
                if (auth.Authenticated)
                {
                    //await DisplayAlert("Success", "Fingerprint matched", "OK");
                    await Navigation.PushAsync(new HomePage());
                    Navigation.RemovePage(this);
                }
                else
                {
                    await DisplayAlert("Failure", "Fingerprint did not match", "Try Again");
                }
            }
        }

        private async void onFPClicked(object sender, EventArgs e)
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync(true);
            if(result)
            {
                var auth = await CrossFingerprint.Current.AuthenticateAsync("Authenticate?");
                if(auth.Authenticated)
                {
                    await DisplayAlert("Success","Fingerprint matched","OK");
                }
                else
                {
                    await DisplayAlert("Failure", "Fingerprint did not match", "Try Again");
                }
            }
        }
    }
}
