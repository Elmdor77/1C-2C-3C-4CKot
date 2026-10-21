/*
Zadanie – Wypożyczalnia sprzętu sportowego

Napisz aplikację w .NET MAUI, która oblicza koszt wypożyczenia
wybranego sprzętu. Całość umieść na jednej stronie MainPage,
bez nawigacji.

Przygotuj w programie kolekcję sprzętu:
- Rower – 40 zł za dzień,
- Hulajnoga – 30 zł za dzień,
- Rolki – 20 zł za dzień,
- Kajak – 50 zł za dzień.

Aplikacja powinna zawierać:
- listę sprzętu – CollectionView z możliwością wyboru jednej pozycji;
 każdy element wyświetla nazwę sprzętu i cenę za dzień,
- imię i nazwisko klienta – Entry,
- liczbę dni wypożyczenia – Stepper od 1 do 7,
- Label pokazujący aktualną liczbę dni,
- ubezpieczenie – CheckBox,
- przycisk „Oblicz koszt”,
- Label wyświetlający podsumowanie.

Aktualna liczba dni powinna być wyświetlana za pomocą bindingu,
tak aby zmieniała się automatycznie wraz z wartością Steppera.

Ubezpieczenie kosztuje dodatkowo 5 zł za każdy dzień wypożyczenia.

Po naciśnięciu przycisku oblicz koszt i wyświetl:
- imię i nazwisko klienta,
- nazwę wybranego sprzętu,
- liczbę dni,
- informację o ubezpieczeniu,
- łączny koszt wypożyczenia.

Przed obliczeniem sprawdź, czy podano imię i nazwisko oraz wybrano
sprzęt. W razie brakujących danych wyświetl odpowiedni komunikat.

Przykład:
Klient: Jan Kowalski
Sprzęt: Rower
Liczba dni: 3
Ubezpieczenie: TAK
Koszt sprzętu: 3 × 40 zł = 120 zł
Ubezpieczenie: 3 × 5 zł = 15 zł
Łącznie: 135 zł
*/

//using SportsEquipmentRentalMauiApp.Data;
using System.Collections.ObjectModel;


namespace SportsEquipmentRentalMauiApp
{
    internal class Car
    {
        public Car()
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
    public partial class MainPage : ContentPage
    { /*

        public ObservableCollection<Car> CarsCollection { get; set; }
        private Car selectedCar;
        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            
            CarsCollection = new ObservableCollection<Car>()
        {
            new Car(){ Name="Fiat", Description = "Kultowy mały fiat"},
            new Car(){ Name="Audi", Description = "A tutaj jego opis"},
        };
            SelectedCar = CarsCollection.First();

            InitializeComponent();
        }*/
    }


}