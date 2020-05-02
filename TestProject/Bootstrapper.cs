using Caliburn.Micro;
using TestProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace TestProject
{
    internal class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainWindowViewModel>();
        }
    }
}