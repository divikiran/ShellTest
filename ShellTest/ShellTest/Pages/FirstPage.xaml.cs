using System;
using System.Collections.Generic;
using ShellTest.ViewModels;
using Xamarin.Forms;

namespace ShellTest.Pages
{
    public partial class FirstPage : ContentPage
    {
        public FirstPageModel VM { get; set; }

        public FirstPage()
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
