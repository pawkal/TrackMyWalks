using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using TrackMyWalks.Models;
using TrackMyWalks.ViewModels;

namespace TrackMyWalks
{
    public class WalkEntryPage : ContentPage
    {
        public WalkEntryPage()
        {
            Title = "Nowy wpis";

            BindingContext = new WalkEntryViewModel();

            var walkTitle = new EntryCell
            {
                Label = "Tytuł:",
                Placeholder = "Nazwa szlaku"
            };
            walkTitle.SetBinding(EntryCell.TextProperty, "Tytuł", BindingMode.TwoWay);

            var walkNotes = new EntryCell
            {
                Label = "Uwagi:",
                Placeholder = "Opis"
            };
            walkNotes.SetBinding(EntryCell.TextProperty, "Uwagi", BindingMode.TwoWay);

            var walkLatitude = new EntryCell
            {
                Label = "Szerokość geograficzna:",
                Placeholder = "Szerokość",
                Keyboard = Keyboard.Numeric
            };
            walkLatitude.SetBinding(EntryCell.TextProperty, "Szerokość geograficzna", BindingMode.TwoWay);

            var walkLongitude = new EntryCell
            {
                Label = "Długość geograficzna:",
                Placeholder = "Długosć",
                Keyboard = Keyboard.Numeric
            };
            walkLongitude.SetBinding(EntryCell.TextProperty, "Długość geograficzna", BindingMode.TwoWay);

            var walkKilometers = new EntryCell
            {
                Label = "Liczba kilometrów",
                Placeholder = "Liczba kilometrów",
                Keyboard = Keyboard.Numeric
            };
            walkKilometers.SetBinding(EntryCell.TextProperty, "Liczba kilometrów", BindingMode.TwoWay);

            var walkDifficulty = new EntryCell
            {
                Label = "Poziom trudności szlaku:",
                Placeholder = "Poziom trudnosci szlaku"
            };
            walkDifficulty.SetBinding(EntryCell.TextProperty, "Poziom trudności", BindingMode.TwoWay);

            var walkImageUrl = new EntryCell
            {
                Label = "URL obrazu",
                Placeholder = "Url obrazu"
            };
            walkImageUrl.SetBinding(EntryCell.TextProperty, "URL obrazu", BindingMode.TwoWay);

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

            saveWalkItem.SetBinding(MenuItem.CommandProperty, "SaveCommand");

            saveWalkItem.Clicked += (sender, e) =>
            {
                Navigation.PopToRootAsync(true);
            };
            ToolbarItems.Add(saveWalkItem);
        }
    }
}