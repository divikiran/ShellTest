using System;
namespace ShellTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetAndRaisePropertyChanged(ref _title, value, nameof(Title));
            }
        }
        public MainViewModel()
        {
            Title = "Main";

        }
    }
}
