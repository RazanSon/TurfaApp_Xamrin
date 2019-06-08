using System;
using System.Collections.Generic;
using Turfa.ViewModels;
using Turfa.Models;

using Xamarin.Forms;

namespace Turfa.Views
{
    public partial class Sours : ContentPage
    {
        HomePageVM homePageVM;
        public Sours()
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
