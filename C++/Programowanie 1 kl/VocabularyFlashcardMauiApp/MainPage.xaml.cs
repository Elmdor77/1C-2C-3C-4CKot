using System.Collections.ObjectModel;

namespace VocabularyFlashcardsMauiApp
{
    public class Flashcard
    {
        public string English { get; set; } = string.Empty;
        public string Polish { get; set; } = string.Empty;
    }

    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<Flashcard> _flashcards = new()
        {
            new Flashcard { English = "apple", Polish = "jabłko" },
            new Flashcard { English = "house", Polish = "dom" },
            new Flashcard { English = "dog",   Polish = "pies" },
            new Flashcard { English = "book",  Polish = "książka" },
            new Flashcard { English = "bike",  Polish = "rower" },
        };

        public MainPage()
        {
            InitializeComponent();
            FlashcardsCarousel.ItemsSource = _flashcards;
            FlashcardsCarousel.Position = 0;
        }

        private void OnShowTranslationClicked(object? sender, EventArgs e)
        {
            if (FlashcardsCarousel.CurrentItem is Flashcard card)
                TranslationLabel.Text = card.Polish;
        }

        private void OnPositionChanged(object? sender, PositionChangedEventArgs e)
        {
            TranslationLabel.Text = string.Empty;
        }

        private void OnRestartClicked(object? sender, EventArgs e)
        {
            FlashcardsCarousel.Position = 0;
            TranslationLabel.Text = string.Empty;
        }
    }
}