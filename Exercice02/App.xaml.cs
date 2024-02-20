namespace Exercice02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            // Définit la page de calculatrice comme page de démarrage
            MainPage = new CalculatricePage();

            //MainPage = new CalculatriceStackLayoutsPage();
        }
    }
}
