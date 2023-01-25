using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TrackMyWalks
{
    public class WalkEntryPage : ContentPage
    {
        public WalkEntryPage()
        {
            Title = "Nowy wpis";

            var walkTitle = new EntryCell
            {
                Label = "Tytuł:",
                Placeholder = "Nazwa szlaku"
            };

            var walkNotes = new EntryCell
            {
                Label = "Uwagi:",
                Placeholder = "Opis"
            };
            var walkLatitude = new EntryCell
            {
                Label = "Szerokość geograficzna:",
                Placeholder = "Szerokość",
                Keyboard = Keyboard.Numeric
            };

            var walkLongitude = new EntryCell
            {
                Label = "Długość geograficzna:",
                Placeholder = "Długosć",
                Keyboard = Keyboard.Numeric
            };

            var walkKilometers = new EntryCell
            {
                Label = "Liczba kilometrów",
                Placeholder = "Liczba kilometrów",
                Keyboard = Keyboard.Numeric
            };

            var walkDifficulty = new EntryCell
            {
                Label = "Poziom trudności szlaku:",
                Placeholder = "Poziom trudnosci szlaku"
            };

            var walkImageUrl = new EntryCell
            {
                Label = "URL obrazu",
                Placeholder = "Url obrazu"
            };

            Content = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection()
                    {
                        walkTitle,
                        walkNotes,
                        walkLatitude,
                        walkLongitude,
                        walkKilometers,
                        walkDifficulty,
                        walkImageUrl
                    }
                }
            };

            var saveWalkItem = new ToolbarItem
            {
                Text = "Zapisz"
            };
            saveWalkItem.Clicked += (sender, e) =>
            {
                Navigation.PopToRootAsync(true);
            };
            ToolbarItems.Add(saveWalkItem);
        }
    }
}