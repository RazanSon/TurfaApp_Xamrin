using System;
using System.Collections.Generic;
using Turfa.Models;
using Xamarin.Forms;
using Turfa.ViewModels;

namespace Turfa.Views
{
    public partial class Sweets : ContentPage
    {
        HomePageVM homePageVM;
        public Sweets()
        {
            homePageVM = new HomePageVM();
            InitializeComponent();
            this.BindingContext = homePageVM;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var ItemSelected = new DetailPage(e.SelectedItem as item);
            await Navigation.PushAsync(ItemSelected);
        }
    }
}
