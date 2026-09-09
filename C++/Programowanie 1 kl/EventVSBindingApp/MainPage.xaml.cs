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
    }
}
