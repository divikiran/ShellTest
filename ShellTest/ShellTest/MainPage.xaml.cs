using System;
using System.Collections.Generic;
using ShellTest.ViewModels;
using Xamarin.Forms;

namespace ShellTest
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
