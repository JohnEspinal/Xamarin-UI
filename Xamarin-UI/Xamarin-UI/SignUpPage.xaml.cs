using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_UI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();
    }

        private async void SignInCompleted_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginUserField.Text) || string.IsNullOrEmpty(LoginPswField.Text) || string.IsNullOrEmpty(LoginPswConfirmField.Text) || string.IsNullOrEmpty(LoginUserNameField.Text))
            {
                await DisplayAlert("Error", "No fields can be empty", "OK");
            }
            else if (LoginPswField.Text != LoginPswConfirmField.Text)
            {
                await DisplayAlert("Error", "The passwords you entered are not the same.", "OK");
            } else
            {
                await DisplayAlert("Welcome!", $"Hello, {LoginUserNameField.Text}. You are succefully Logged In.", "OK");
                
                await Navigation.PushAsync(new HomePage());
            }
        }
    }
}