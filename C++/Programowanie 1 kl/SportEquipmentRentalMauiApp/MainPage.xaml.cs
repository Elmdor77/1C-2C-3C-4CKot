
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

using System.Collections.ObjectModel;

namespace SportsEquipmentRentalMauiApp
{
    public class Equipment
    {
        public string Name { get; set; } = string.Empty;
        public int PricePerDay { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        private int DailyInsurance = 5;

        private readonly ObservableCollection<Equipment> equipment = new()
        {
            new Equipment { Name = "Rower",      PricePerDay = 40 },
            new Equipment { Name = "Hulajnoga",  PricePerDay = 30 },
            new Equipment { Name = "Rolki",      PricePerDay = 20 },
            new Equipment { Name = "Kajak",      PricePerDay = 50 },
        };

        public MainPage()
        {
            InitializeComponent();
            EquipmentCollection.ItemsSource = equipment;
        }

        private void Calculate(object? sender, EventArgs e)
        {
            string customer = CustomerEntry.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(customer))
            {
                SummaryLabel.Text = "Podaj imię i nazwisko klienta.";
                return;
            }

            if (EquipmentCollection.SelectedItem is not Equipment selected)
            {
                SummaryLabel.Text = "Wybierz sprzęt z listy.";
                return;
            }

            int days = (int)DaysStepper.Value;
            bool IsInsurance = InsuranceCheckBox.IsChecked;

            int equipmentCost = days * selected.PricePerDay;
            int insuranceCost = IsInsurance ? days * DailyInsurance : 0;
            int total = equipmentCost + insuranceCost;

            string text =
                $"Klient: {customer}\n" +
                $"Sprzęt: {selected.Name}\n" +
                $"Liczba dni: {days}\n" +
                $"Ubezpieczenie: {(IsInsurance ? "TAK" : "NIE")}\n" +
                $"Koszt sprzętu: {days} × {selected.PricePerDay} zł = {equipmentCost} zł\n";

            if (IsInsurance)
                text += $"Ubezpieczenie: {days} × {DailyInsurance} zł = {insuranceCost} zł\n";

            text += $"Łącznie: {total} zł";

            SummaryLabel.Text = text;
        }
    }
}