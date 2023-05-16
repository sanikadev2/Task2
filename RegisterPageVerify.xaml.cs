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
	public partial class RegisterPageVerify : ContentPage
	{
		public RegisterPageVerify ()
		{
			InitializeComponent ();
		}

        private async void onRegisterButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hi", "Login Successfull", "Ok");
        }
    }
}