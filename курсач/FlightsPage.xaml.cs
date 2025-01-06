using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace курсач
{
    public partial class FlightsPage : ContentPage
    {
        public FlightsPage()
        {
            InitializeComponent();
            LoadFlights();
        }

        private void LoadFlights()
        {
            var flights = new List<Flight>
            {
                new Flight { FlightInfo = "Москва, ул. Ленина, 31.12.2024 15:35" },
                new Flight { FlightInfo = "Санкт-Петербург, ул. Невский, 01.01.2025 10:00" },
                new Flight { FlightInfo = "Казань, ул. Баумана, 02.01.2025 12:30" },
                new Flight { FlightInfo = "Екатеринбург, ул. Ленина, 03.01.2025 14:45" },
                new Flight { FlightInfo = "Новосибирск, ул. Красный проспект, 04.01.2025 09:15" },
                new Flight { FlightInfo = "Нижний Новгород, ул. Большая Покровская, 05.01.2025 11:00" },
                new Flight { FlightInfo = "Челябинск, ул. Труда, 06.01.2025 16:20" },
                new Flight { FlightInfo = "Ростов-на-Дону, ул. Садовая, 07.01.2025 08:50" },
                new Flight { FlightInfo = "Уфа, ул. Ленина, 08.01.2025 13:00" },
                new Flight { FlightInfo = "Волгоград, ул. Комсомольская, 09.01.2025 17:30" },
                new Flight { FlightInfo = "Сочи, ул. Курортный проспект, 10.01.2025 09:00" },
                new Flight { FlightInfo = "Калуга, ул. Кирова, 11.01.2025 14:15" },
                new Flight { FlightInfo = "Тюмень, ул. Республики, 12.01.2025 11:45" },
                new Flight { FlightInfo = "Воронеж, ул. Плехановская, 13.01.2025 16:30" },
                new Flight { FlightInfo = "Ижевск, ул. Карла Маркса, 14.01.2025 10:50" },
                new Flight { FlightInfo = "Барнаул, ул. Ленина, 15.01.2025 12:00" },
                new Flight { FlightInfo = "Саратов, ул. Московская, 16.01.2025 15:20" },
                new Flight { FlightInfo = "Тула, ул. Ленина, 17.01.2025 13:10" },
                new Flight { FlightInfo = "Кострома, ул. Советская, 18.01.2025 09:30" },
                new Flight { FlightInfo = "Пенза, ул. Красная, 19.01.2025 11:00" }
            };

            flightsListView.ItemsSource = flights;
        }

        private async void OnDownloadClicked(object sender, EventArgs e)
        {
            // Логика для скачивания списка полетов
            await DisplayAlert("Скачать", "Функция скачивания еще не реализована.", "OK");
        }

        private async void OnHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }

    public class Flight
    {
        public string FlightInfo { get; set; }
    }
}
