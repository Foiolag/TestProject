using Caliburn.Micro;
using System;
using System.Collections.Generic;

namespace TestProject.ViewModels
{
    internal class MainWindowViewModel : Screen
    {
        public MainWindowViewModel()
        {
            Dates.Add(DateTime.Today);
            Dates.Add(DateTime.Today.AddDays(2));
            Dates.Add(DateTime.Today.AddDays(4));
        }
       
        public HashSet<DateTime> Dates { get; } = new HashSet<DateTime>();


        public void btAddDay()
        {
            //It is not the most suitable way, just for example
            Dates.Add(DateTime.Today.AddDays(6));
            NotifyOfPropertyChange(() => Dates);
        }
    }
}