using Turfa.Models;
using Turfa.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Turfa.Views
{
    public partial class DetailPage : ContentPage
    {
        item product;
        DetailPageVM viewModel;

        public DetailPage()
        {
        }
        public DetailPage(item ItemSelected)
        {
            InitializeComponent();

            viewModel = new DetailPageVM();
            BindingContext = viewModel;

            Title = ItemSelected.Name;
            image.Source = ItemSelected.Image;
            title.Text = ItemSelected.Name;
            Price.Text = ItemSelected.Price;
            Description.Text = ItemSelected.Description;
            product = ItemSelected;
        }

        void CallNow(object sender, System.EventArgs e)
        {
            try
            {
                PhoneDialer.Open(product.Phone);
            }
            catch (ArgumentNullException)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException)
            {
                DisplayAlert("Problem", "Not Supported here on the emulator", "continue");
            }
            catch (Exception)
            {
                // Other error has occurred.
            }
        }

        private async void MailTo(object sender, EventArgs e)
        {
            // open email app to send email 
            try
            {
                await viewModel.SendEmail("Order" + product.Name,
                "Order the " + product.Name + " with: number of pieces  ",
                new List<string> { "Turfa@gmail.com" });
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                await DisplayAlert("Alert", fbsEx.Message, "Ok");
            }

        }

        private void MapTo(object sender, EventArgs e)
        {
            //open Map app to diplay spesific location 
            try
            {
                Map.OpenAsync(product.x, product.y, new MapLaunchOptions { Name = "Turfa" });
            }
            catch (Exception ex)
            {
                DisplayAlert("Alert", ex.Message, "Ok");
            }
        }
    }
}
