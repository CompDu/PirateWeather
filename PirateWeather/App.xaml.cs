


namespace PirateWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            
        }

        protected override Window CreateWindow(IActivationState activationState)
        {

            var window = base.CreateWindow(activationState);
#if WINDOWS
            const int newHeight = 800;
            const int newWidth = 600;

            window.Height = newHeight;
            window.Width = newWidth;
#endif
            return window;
        }

    }
}