using System;
using System.Collections.Generic;
using System.Text;
using TrackMyWalks.Models;

namespace TrackMyWalks.ViewModels
{
    public class WalkTrailViewModel : WalkBaseViewModel
    {
        WalkEntries _walkEntry;
        public WalkEntries _walkEntries
        {
            get { return _walkEntry; }
            set
            {
                _walkEntry = value;
                OnPropertyChanged();
            }

        }
        public WalkTrailViewModel(WalkEntries walkEntry)
        {
            walkEntry = walkEntry;
        }
    }

}
