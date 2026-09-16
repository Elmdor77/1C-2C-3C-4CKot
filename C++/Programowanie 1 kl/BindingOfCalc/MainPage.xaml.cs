namespace BindingOfCalc
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public string FirstNumber { get; set; }

        public string SecondNumber { get; set; }

        public string Result;


        public string GetResult
        {

            get { return Result; }

            set
            {
                Result = value;
                //OnPropertyChanged(nameof("ReturnMessage");
                OnPropertyChanged();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            {
                if (int.TryParse(FirstNumber, out int firstNumber)
                    && int.TryParse(SecondNumber, out int secondNumber))
                {
                    GetResult = $"{firstNumber + secondNumber}";


                }
                else
                {
                    GetResult = "Źle wpisane dane";
                    
                }
            }
            
        }
    }
}
