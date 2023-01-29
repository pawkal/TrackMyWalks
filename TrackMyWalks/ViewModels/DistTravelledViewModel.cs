using System;
using System.Collections.Generic;
using System.Text;
using TrackMyWalks.Models;
using TrackMyWalks.ViewModels;

namespace TrackMyWalks.ViewModels
{
   public class DistTrevelledViewModels : WalkBaseViewModel
    {
        WalkEntries _walkEntry;

        public WalkEntries WalkEntry
        {
            get { return _walkEntry; }
            set
            {
                _walkEntry = value;
                OnPropertyChanged();
            }
        }
        double _travelled;
            public double Travelled
        {
            get { return _travelled; }
            set
            {
                _travelled = value;
                OnPropertyChanged();
            }
        }
        double _hours;
        public double Hours
        {
            get { return _hours; }  
            set
            {
                _hours = value;
                OnPropertyChanged();
            }
        }
        double _minutes;
        public double minutes
        {
            get { return _minutes; }
            set
            {
                _minutes = value;
                OnPropertyChanged();
            }
        }
        double _seconds;
        public double seconds
        {
            get { return _seconds; }
            set
            {
                _seconds = value;
                OnPropertyChanged();

            }
        }
        public string TimeTaken
        {
            get
            {
                return string.Format("{0:00{ 1:00}:{ 2:00}", this.Hours, this.minutes, this.seconds);
            }
        }

        public DistTrevelledViewModels(WalkEntries walkEntry) 
        {
            this.Hours = 0;
            this.minutes= 0;
            this.seconds = 0;
            this.Travelled = 0;

            WalkEntry = walkEntry;

        }
    }
}
