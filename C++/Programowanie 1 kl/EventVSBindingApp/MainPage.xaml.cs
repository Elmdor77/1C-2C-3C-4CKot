namespace EventVSBindingApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (RotationLabel is not null
                && sender is Slider slider)
                RotationLabel.Rotation = slider.Value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            pokaszLabel.Text = podajEntry.Text;
            podajEntry.Text = "";

        }

        public string Message { get; set; }

        private string returnMessage;
        public string ReturnMessage
        {

            get { return returnMessage; }

            set
            {
                returnMessage = value;
                //OnPropertyChanged(nameof("ReturnMessage");
                OnPropertyChanged();
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ReturnMessage = Message;
        }
    }
}
