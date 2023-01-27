using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrackMyWalks.Models;

namespace TrackMyWalks.ViewModels
{
    public class WalkPageViewModel : WalkBaseViewModel
    {
        ObservableCollection<WalkEntries> _walkEntries;

        public ObservableCollection<WalkEntries> walkEntries
        {
            get { return _walkEntries; }
            set { _walkEntries = value;
                OnPropertyChanged();

            }
        }
    }
}
