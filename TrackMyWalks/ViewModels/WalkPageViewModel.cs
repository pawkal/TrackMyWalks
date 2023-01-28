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

        public WalkPageViewModel()
        {
            walkEntries = new ObservableCollection<WalkEntries>()
            {
                new WalkEntries
                {
                    Title = "10-milowy szlak wzdłuż strumienia, Margaret River",
                    Notes = " 10-cio milowy szlak wzdłuż strumienia zaczyna się w Rotary Park w pobliżu" +
                    "Old Kate,  czyli starej lokomotywy stojącej w północnej części Margaret River.",
                    Latitude = -33.9727604,
                    Longitude = 115.0861599,
                    Kilometers = 7,5,
                    Distance = 0,
                    Difficulty = "Średni",
                    ImageUrl = "https://trailswa.com.au/storage/media/9yz4pplk4qdk/conversions/South_Loop-crop-1066x840-webp.webp"

                },
                new WalkEntries
                {
                     Title = "Szlak Ancient Empire, Dolina gigantów",
                    Notes = "Ancient Empire to 450-metrowy szlak pośród " +
                    "Gigantycznych drzew , wsród których znajduje się popularne " +
                    "sękate olbrzymy zwane Grandma Tingle.",
                    Latitude = -34.9749188,
                    Longitude = 117.3560796,
                    Kilometers = 450,
                    Distance = 0,
                    Difficulty = "Wysoki",
                    ImageUrl = "https://ourlittleadventures.pl/wp-content/uploads/2019/07/mapatrasaWawa.png"
                },
            };
        }
    }
}
