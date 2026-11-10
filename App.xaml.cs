namespace MAUIRockPaperScissors
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Kis ablak asztali platformon (Windows, Mac Catalyst);
            // a méret eszközfüggetlen egységben értendő, mobilon nincs hatása.
            return new Window(new AppShell())
            {
                Width = 320,
                Height = 400
            };
        }
    }
}
