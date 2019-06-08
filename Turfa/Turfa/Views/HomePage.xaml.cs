using System;
using System.Collections.Generic;
using Turfa.Models;
using Xamarin.Forms;
using Turfa.ViewModels;
using Xamarin.Essentials;

namespace Turfa.Views
{
    public partial class HomePage : ContentPage
    {
        HomePageVM HomePageVM = new HomePageVM();

        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = HomePageVM;
        }

        async void Sweets(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sweets());
        }

        async void Sours(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sours());
        }

        async void Healthy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Healthy());
        }

        private async void openBrowser(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.instagram.com/turfa__/?hl=en", BrowserLaunchMode.SystemPreferred);
        }
    }
}
