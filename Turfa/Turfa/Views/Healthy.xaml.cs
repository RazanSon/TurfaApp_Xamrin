using System;
using System.Collections.Generic;
using Turfa.Models;
using Turfa.ViewModels;
using Xamarin.Forms;

namespace Turfa.Views
{
    public partial class Healthy : ContentPage
    {
        HomePageVM homePageVM;
        public Healthy()
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
