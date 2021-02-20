using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_UI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(LoginUserField.Text))
            {
                await DisplayAlert("Error", "User field cannot be empty", "OK");
            }else if(string.IsNullOrEmpty(LoginPswField.Text))
            {
                await DisplayAlert("Error", "Password field cannot be empty", "OK");
            }
            else
            {
                await DisplayAlert("Welcome!", $"Hello, {LoginUserField.Text}. You are succefully Logged In.", "OK");
                await Navigation.PushAsync(new HomePage());
            }
        }

        private async void SignUpClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
