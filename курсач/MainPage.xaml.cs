using System;
using Xamarin.Forms;

namespace курсач
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTakePhotoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CameraPage());
        }

        private async void OnGalleryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
        }

        private async void OnFlightsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlightsPage());
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}

