using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using TrackMyWalks.Models;
using TrackMyWalks.ViewModels;
using Xamarin.Forms.Maps;

namespace TrackMyWalks
{
    public class WalkTrailPage : ContentPage
    {
        public WalkTrailPage(WalkEntries walkItem)
        {
            Title = "Szlak";

            BindingContext = new WalkTrailViewModel(walkItem);

            var beginTrailWalk = new Button
            {
                BackgroundColor = Color.FromHex("#008080"),
                TextColor = Color.White,
                Text = "Rozpocznij ten szlak"
            };

            beginTrailWalk.Clicked += (sender, e) =>
            {
                if (walkItem == null) return;
                Navigation.PushAsync(new DistanceTravelledPage(walkItem));
                Navigation.RemovePage(this);
                walkItem = null;
            };

            var walkTrailImage = new Image()
            {
                Aspect = Aspect.AspectFill,
                Source = walkItem.ImageUrl
            };

            walkTrailImage.SetBinding(Image.TabIndexProperty, "WalkEntry.ImageUrl");

            var trailNameLabel = new Label()
            {
                FontSize = 28,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                Text = walkItem.Title
            };
            trailNameLabel.SetBinding(Label.TextProperty, "WalkEntry.Title");

            var trailKilometersLabel = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 12,
                TextColor = Color.Black,
                Text = $"Długość: {walkItem.Kilometers} km"

            };
            trailKilometersLabel.SetBinding(Label.TextProperty, "WalkEntry.Kilometers", stringFormat: "Długość {0} km");

            var trailDifficultyLabel = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 12,
                TextColor = Color.Black,
                Text = $"Poziom trudności: {walkItem.Difficulty} "
            };
            trailDifficultyLabel.SetBinding(Label.TextProperty, "WalkEntry.Difficulty", stringFormat: "Poziom trudności: {0}");

            var trialFullDescription = new Label()
            {
                FontSize = 11,
                TextColor = Color.Black,
                Text = $"{walkItem.Notes}",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            trialFullDescription.SetBinding(Label.TextProperty, "WalkEntry.Notes");

            this.Content = new ScrollView
            {
                Padding = 10,
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children =
                    {
                        walkTrailImage,
                        trailNameLabel,
                        trailKilometersLabel,
                        trailDifficultyLabel,
                        trialFullDescription,
                        beginTrailWalk

                    }
                }
            };
        }
    }
}