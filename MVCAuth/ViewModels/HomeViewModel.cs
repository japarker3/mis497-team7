using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using MVCAuth.Models;

namespace MVCAuth.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel(bool isAuthenticated)
        {
            IsAuthenticated = isAuthenticated;
        }

        public bool IsAuthenticated { get; private set; }

        public IList<ActivityViewModel> Activities { get; } = new ObservableCollection<ActivityViewModel>();
        public IList<Athlete> Ath { get; } = new ObservableCollection<Athlete>();


    }
}