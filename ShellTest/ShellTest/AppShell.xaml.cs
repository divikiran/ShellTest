using System;
using System.Collections.Generic;
using ShellTest.ViewModels;
using Xamarin.Forms;

namespace ShellTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
