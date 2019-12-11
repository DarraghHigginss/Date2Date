using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DbD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when the app starts
        }

        protected override void OnSleep()
        {
            // Handle when the app sleeps
        }

        protected override void OnResume()
        {
            // Handle when the app resumes
        }
    }
}
