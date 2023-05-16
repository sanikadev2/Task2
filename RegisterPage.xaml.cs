using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.AppleSignInAuthenticator;

namespace MondayTask
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage, INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> Options { get; set; } // List of options

        private string selectedOption;
        public string SelectedOption
        {
            get { return selectedOption; }
            set
            {
                selectedOption = value;
                OnPropertyChanged();
            }
        }

        public RegisterPage ()
		{
			InitializeComponent ();
            Options = new List<string>
            {
                "Option 1", "Option 2", "Option 3", "Option 4" // Add more options as needed
            };
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedOption = (string)picker.SelectedItem;

            // Do something with the selected option
        }

        private async void onRegisterButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPageVerify ());
        }
    }
}