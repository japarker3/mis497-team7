using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StravaSharp;

namespace MVCAuth.ViewModels
{
    public class AthleteViewModel
    {
        private AthleteSummary _summary;

        public AthleteViewModel(AthleteSummary summary)
        {
            _summary = summary;
        }

        public string FName => _summary.FirstName;
        public string LName => _summary.LastName;
        public string City => _summary.City;
        public string State => _summary.State;
    }
}
