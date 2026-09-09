namespace SimpleCalculatorApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(FirstNumberEntry.Text, out int FirstNumber)
                && int.TryParse(SecondNumberEntry.Text, out int SecondNumber))
            {
                ResultLabel.Text = $"Wynik dodawania: {FirstNumber + SecondNumber}";
                ResultLabel.BackgroundColor = Colors.GreenYellow;


            }
            else
            {
                ResultLabel.Text= "Źle wpisane dane";
                ResultLabel.BackgroundColor = Colors.PaleVioletRed;
            }
        }
    }
}
