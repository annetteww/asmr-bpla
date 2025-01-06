using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace курсач
{
    public partial class GalleryPage : ContentPage
    {
        // Коллекция для хранения изображений
        public ObservableCollection<Photo> Photos { get; set; }

        public GalleryPage()
        {
            InitializeComponent();
            Photos = new ObservableCollection<Photo>
            {
                new Photo { Thumbnail = "image1_thumbnail", FullImagePath = "image1_full" },
                new Photo { Thumbnail = "image2_thumbnail", FullImagePath = "image2_full" },
                new Photo { Thumbnail = "image3_thumbnail", FullImagePath = "image3_full" }
            };
            photoListView.ItemsSource = Photos; // Привязка коллекции к ListView
        }

        // Обработчик для просмотра изображения
        private async void OnPhotoTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var selectedPhoto = e.Item as Photo; // Получаем выбранный объект Photo

                // Получаем поток изображения
                Stream imageStream = await GetImageStream(selectedPhoto.FullImagePath);

                // Переход на страницу просмотра изображения, передавая поток
                await Navigation.PushAsync(new ImageViewPage(imageStream));
            }
        }

        // Метод для получения потока изображения
        private async Task<Stream> GetImageStream(string imagePath)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException($"File '{imagePath}' not found.");
            }

            return await Task.FromResult(File.OpenRead(imagePath));
        }

        // Обработчик для удаления изображения
        private async void OnDeletePhotoClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var photoToDelete = button.BindingContext as Photo;

            if (photoToDelete != null)
            {
                Photos.Remove(photoToDelete);
                // Здесь вы можете добавить код для удаления изображения из файловой системы или базы данных
            }
        }

        // Обработчик для кнопки "На главную"
        private async void OnHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Возвращаемся на предыдущую страницу
        }
    }

    // Класс для представления фотографии
    public class Photo
    {
        public string Thumbnail { get; set; } // Путь к миниатюре
        public string FullImagePath { get; set; } // Путь к полному изображению
    }
}
