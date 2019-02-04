using System;
using ShellTest.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ShellTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            RegisterRoutes();
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new MainPage();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("aboutpage", typeof(AboutPage));
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
