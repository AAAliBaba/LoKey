using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoKey
{
    public partial class AddKeyPage : ContentPage
    {
        public AddKeyPage()
        {
            InitializeComponent();
        }

        async void onCommitClicked(object sender, EventArgs e)
        {
            if(entry_name.Text == null)
            {
                await DisplayAlert("Notice", "Please enter a name for your key", "OK");
            }
            else
            {
                App.keychain.AddKey(entry_name.Text.ToString());
                await Navigation.PushAsync(new HomePage());
            }
        }
    }
}
