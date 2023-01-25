using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackMyWalks.Models;
using Xamarin.Forms;

namespace TrackMyWalks
{
    public class WalksPage : ContentPage
    {
        public WalksPage()
        {
            var newWalkItem = new ToolbarItem
            {
                Text = "Dodaj szlak"
            };
            newWalkItem.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new WalkEntryPage());
            };
            ToolbarItems.Add(newWalkItem);
            var walkItems = new List<WalkEntries>
            {
                new WalkEntries
                {
                    Title = "10-milowy szlak wzdłuż stumienia, Margaret River",
                    Notes = "10-milowy szlak wzdłuż strumienia zaczyna się " +
                    "w Rotory Park w pobliżu Old Kate, czyli starej lokomotywy" +
                    "stojącej w północnej cześci Margaret River.",
                    Latitude = -33.9727604,
                    Longitude = 115.0861599,
                    Kilometers = 7.5,
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
            var itemTemplate = new DataTemplate(typeof(ImageCell));
            itemTemplate.SetBinding(TextCell.TextProperty, "Title");
            itemTemplate.SetBinding(TextCell.DetailProperty, "Notes");
            itemTemplate.SetBinding(ImageCell.ImageSourceProperty, "ImageUrl");

            var walksList = new ListView
            {
                HasUnevenRows = true,
                ItemTemplate = itemTemplate,
                ItemsSource = walkItems,
                SeparatorColor = Color.FromHex("#ddd"),
            };
            walksList.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                var item = (WalkEntries)e.Item;
                if (item == null) return;
                Navigation.PushAsync(new WalkTrailPage(item));
                item = null;
            };
            Content = walksList;
        }
    }
}