using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Turfa.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void LogIn(object sender, EventArgs e)
        {
            if (un.Text == "Razan" && pass.Text == "2019")
            {
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Invalid", "Wrong Password or ID", "close");
            }
        }
    }
}
