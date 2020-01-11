using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoKey
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            //App.keychain.AddKey("frontdoor");
            //App.keychain.AddKey("backdoor");
            //App.keychain.AddKey("bathroom");

            NavigationPage.SetHasNavigationBar(this, false);

            int count = 0;

            foreach (Key k in App.keychain.Keys)
            {
                Label label = new Label
                {
                    Text = k.Name,
                    FontSize = 57.5,
                    HorizontalTextAlignment = TextAlignment.Center,
                };

                ImageButton img = new ImageButton
                {
                    HeightRequest = 275,
                    WidthRequest = Application.Current.MainPage.Width,
                    Source = k.Image,
                    BackgroundColor = Color.White,
                };
                img.Clicked += btnPopupButton_Clicked;

                bot_grid_child.Children.Add(img, count, 0);
                bot_grid_child.Children.Add(label, count, 1);
                count++;
            }
        }

        async void onAddClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddKeyPage());
        }

        //void onImgClicked(object sender, EventArgs e)
        //{
        //    modal
        //}


        private void btnPopupButton_Clicked(object sender, EventArgs e)
        {
            bool is_visible = popupLoadingView.IsVisible;
            popupLoadingView.IsVisible = is_visible? false : true;
        }
    }
}
