using System;
using Xamarin.Forms;

namespace курсач
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void OnHelpClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Справка", "Здесь будет информация о приложении.", "OK");
        }

        private async void OnHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
