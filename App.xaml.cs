namespace MauiApp7
{
    public partial class App : Application
    {
        public App(MainPage mainPage)
        {
            InitializeComponent();

            Routing.RegisterRoute("Wichard_Page", typeof(Wichard_Page));
                Routing.RegisterRoute("Wichard_Page_Main", typeof(Wichard_Page_Main));
                Routing.RegisterRoute("Wichard_Page_Inventory", typeof(Wichard_Page_Inventory));

            Routing.RegisterRoute("Cyberpunk_red_Page", typeof( Cyberpunk_red_Page ));
            
            MainPage = new AppShell();
        }
    }
}
