using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TrackMyWalks.Models;
using Xamarin.Forms;
using TrackMyWalks.ViewModels;

namespace TrackMyWalks.ViewModels
{
    public class WalkEntryViewModel : WalkBaseViewModel
    {
        string _title;
            public string title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
                SaveCommand.ChangeCanExecute();
            }
        }
        string _notes;
        public string notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                OnPropertyChanged();
            }
        }
        double _latitude;
        public double latitude
        {
            get { return _latitude; }
            set
            {
                _latitude = value;
                OnPropertyChanged();
            }
        }
        double _longitude;
        public double longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }
        }
        double _kilometers;
        public double kilometers
        {
            get { return _kilometers;}
            set
            {
                _kilometers = value;
                OnPropertyChanged();
            }
        }
        string _difficulty;
        public string difficulty
        {
            get { return _difficulty; }
            set
            {
                _difficulty = value;
                OnPropertyChanged();
            }
        }
        double _distance;
        public double distance
        {
            get { return _distance; }
            set
            {
                _distance = value;
                OnPropertyChanged();
            }
        }
        string _imageURL;
        public string ImageURL
        {
            get { return _imageURL; }
            set
            {
                _imageURL = value;
                OnPropertyChanged();
            }
        }
        public WalkEntryViewModel()
        {
            title = "Nowy Szlak";
            difficulty = "Niski";
            distance = 1.0;
        }
        Command _saveCommand;
        public Command SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new Command(ExecuteSaveCommand, ValidateFormDetails));
            }
        }
        void ExecuteSaveCommand()
        {
            var newWalkItem = new WalkEntries
            {
                Title = this.title,
                Notes = this.notes,
                Latitude = this.latitude,
                Longitude = this.longitude,
                Kilometers = this.kilometers,
                Difficulty = this.difficulty,
                Distance = this.distance,
                ImageUrl = this.ImageURL,
            };

        }
        bool ValidateFormDetails()
        {
            return !string.IsNullOrWhiteSpace(title);
        }
    }
}
