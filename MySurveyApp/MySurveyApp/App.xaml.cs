using Xamarin.Forms;

namespace MySurveyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SurveyPage();
            MainPage.BindingContext = new ViewModels.SurveyViewModel();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
