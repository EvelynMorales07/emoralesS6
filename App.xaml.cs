using emoralesS6.Views;

namespace emoralesS6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new vEstudiante();
        }
    }
}
