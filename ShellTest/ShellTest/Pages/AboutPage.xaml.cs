using System;
using System.Collections.Generic;
using ShellTest.ViewModels;
using Xamarin.Forms;

namespace ShellTest.Pages
{
    [QueryProperty("Message", "msg")]
    public partial class AboutPage : ContentPage
    {
        public FirstPageModel VM { get; set; }
        string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
            }
        }

        public AboutPage()
        {
            InitializeComponent();
            BindingContext = VM = new FirstPageModel();
            SetBinding(Shell.NavBarIsVisibleProperty, new Binding(nameof(VM.ShowNavBar)));

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
