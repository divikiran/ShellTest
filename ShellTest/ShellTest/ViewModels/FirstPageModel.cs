using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellTest.ViewModels
{
    public class FirstPageModel : BaseViewModel
    {
        private ICommand _goToAboutCommandAsync;

        public bool ShowNavBar { get; set; }

        public ICommand GoToAboutCommandAsync
        {
            get { return _goToAboutCommandAsync; }
            set
            {
                _goToAboutCommandAsync = value;
                NotifyPropertyChanged(nameof(GoToAboutCommandAsync));
            }
        }


        public FirstPageModel()
        {
            ShowNavBar = true;
            GoToAboutCommandAsync = new Command(GotoAboutPage);
        }

        async void GotoAboutPage(object obj)
        {
            //await (App.Current.MainPage as Shell).GoToAsync("app:///ShellTest/Pages/aboutpage?msg=Hello");

            await (App.Current.MainPage as Shell).GoToAsync(new ShellNavigationState(new Uri("app://microsoft.com/ShellTest/aboutpage?msg=Hello")));

        }

    }
}
