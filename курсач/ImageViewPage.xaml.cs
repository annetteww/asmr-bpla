using System;
using System.IO;
using Xamarin.Forms;

namespace курсач
{
    public partial class ImageViewPage : ContentPage
    {
        public ImageViewPage(Stream imageStream)
        {
            InitializeComponent();
            DisplayImage(imageStream);
        }

        private void DisplayImage(Stream imageStream)
        {
            // Устанавливаем источник изображения
            imageView.Source = ImageSource.FromStream(() => imageStream);
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnShareClicked(object sender, EventArgs e)
        {
            // Реализуйте логику для поделиться изображением
        }
    }
}