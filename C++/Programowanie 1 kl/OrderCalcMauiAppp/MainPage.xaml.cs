/*
Zadanie – Kalkulator kosztu zamówienia
Napisz aplikację w .NET MAUI, która pozwala obliczyć koszt prostego zamówienia.

Aplikacja powinna zawierać:
- pole Nazwa produktu (Entry),
- pole Cena za sztukę (Entry),
- wybór liczby sztuk za pomocą kontrolki Stepper (od 1 do 10),
- Label wyświetlający aktualnie wybraną liczbę sztuk,
- przełącznik Dostawa ekspresowa (Switch),
- przycisk Oblicz,
- Label wyświetlający podsumowanie zamówienia i końcową cenę.

Zasady obliczeń:
Koszt zamówienia oblicz według wzoru:
cena za sztukę × liczba sztuk
Jeśli użytkownik włączy dostawę ekspresową, do ceny zamówienia należy doliczyć 15 zł.

Przykład:
Produkt: Słuchawki
Cena za sztukę: 120 zł
Liczba sztuk: 3
Dostawa ekspresowa: TAK  
Wynik: 375 zł



Dla chętnych: zamiast przełącznika dostawy ekspresowej dodaj Picker, który pozwala wybrać sposób dostawy:
- Odbiór osobisty – 0 zł
- Kurier – 12 zł
- Paczkomat – 10 zł
Wybrany sposób dostawy uwzględnij podczas obliczania końcowej ceny zamówienia.
*/


namespace OrderCalcMauiAppp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private string Nazwa;
        public string nazwa
        {
            get { return Nazwa; }
            set { Nazwa = value; OnPropertyChanged(); }
        }
        private string Cena;
        public string cena
        {
            get { return Cena; }
            set { Cena = value; OnPropertyChanged(); }
        }
        private string Ilosc;
        public string ilosc
        {
            get { return Ilosc; } 
            set { Ilosc = value; OnPropertyChanged(); }
        }
        private bool on;
        public bool isOn
        {
            get { return on; }
            set { on = value; OnPropertyChanged(); }
        }

        private string Sum;
        public string showSum
        {
            get { return Sum; }
            set { Sum = value; OnPropertyChanged(); }
        }
        public void Button_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(ilosc, out int iloscPrzedmiotu)
                    && int.TryParse(cena, out int cenaPrzedmiotu))
            {
                Sum = $"{iloscPrzedmiotu * cenaPrzedmiotu}";


            }
            else
            {
                Sum  = "Źle wpisane dane";

            }
        }
    }
}
