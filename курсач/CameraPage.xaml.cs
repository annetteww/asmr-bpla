using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace курсач
{
    public partial class CameraPage : ContentPage
    {
        public CameraPage()
        {
            InitializeComponent();
        }

        private async void OnCapturePhotoClicked(object sender, EventArgs e)
        {
            try
            {
                // Запрос на съемку фотографии
                var photo = await MediaPicker.CapturePhotoAsync();

                // Получение потока захваченного изображения
                var stream = await photo.OpenReadAsync();

                // Переход на страницу просмотра изображения, передавая поток
                await Navigation.PushAsync(new ImageViewPage(stream));
            }
            catch (Exception ex)
            {
                // Обработка ошибок (например, если пользователь отменил съемку)
                await DisplayAlert("Ошибка", ex.Message, "OK");
            }
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
