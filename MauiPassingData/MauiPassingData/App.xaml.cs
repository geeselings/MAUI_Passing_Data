namespace MauiPassingData
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Set the MainPage wrapped in a NavigationPage
            return new Window(new NavigationPage(new MainPage()));
        }
    }
}