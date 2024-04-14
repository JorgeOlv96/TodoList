using LocalizationResourceManager.Maui;

namespace TodoList
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        ILocalizationResourceManager _localizationResourceManager;
        LocalizedString counterClicked;


        public MainPage(ILocalizationResourceManager localizationResourceManager)
        {
            InitializeComponent();
            _localizationResourceManager = localizationResourceManager;
            counterClicked = new(() => _localizationResourceManager["CounterClicked"]);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (_localizationResourceManager.CurrentCulture.TwoLetterISOLanguageName == "nl")
                _localizationResourceManager.CurrentCulture = new System.Globalization.CultureInfo("en");
            else
                _localizationResourceManager.CurrentCulture = new System.Globalization.CultureInfo("nl");

        
            count++;

            CounterBtn.Text = string.Format(counterClicked.Localized, count);

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

    }

}
