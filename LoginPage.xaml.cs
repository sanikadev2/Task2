using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MondayTask
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void onLoginButton_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Hi", "Login Successfull", "Ok");
			await Navigation.PushAsync(new Step2 ());
        }
    }
}