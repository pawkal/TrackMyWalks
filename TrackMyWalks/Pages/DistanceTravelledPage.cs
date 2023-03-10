using Xamarin.Forms;
using Xamarin.Forms.Maps;
using TrackMyWalks.Models;
using TrackMyWalks.ViewModels;

namespace TrackMyWalks
{
    public class DistanceTravelledPage : ContentPage
    {
        DistTrevelledViewModels _viewModel
        {
            get { return BindingContext as DistTrevelledViewModels; }
        }

        public DistanceTravelledPage(WalkEntries walkItem)
        {
            Title = "Distance Travelled";

          
            BindingContext = new DistTrevelledViewModels(walkItem);

            
            var trailMap = new Map();

            
            trailMap.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = _viewModel.WalkEntry.Title,
                Position = new Position(_viewModel.WalkEntry.Latitude, _viewModel.WalkEntry.Longitude)
            });

            
            trailMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(_viewModel.WalkEntry.Latitude, _viewModel.WalkEntry.Longitude), Distance.FromKilometers(1.0)));

            var trailNameLabel = new Label()
            {
                FontSize = 18,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center
            };

            trailNameLabel.SetBinding(Label.TextProperty, "WalkEntry.Title");

            var trailDistanceTravelledLabel = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center
            };

            trailDistanceTravelledLabel.SetBinding(Label.TextProperty, "Travelled", stringFormat: "Distance Travelled: {0} km");

            var totalTimeTakenLabel = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center
            };

            totalTimeTakenLabel.SetBinding(Label.TextProperty, "TimeTaken", stringFormat: "Time Taken: {0}");

            var walksHomeButton = new Button
            {
                BackgroundColor = Color.FromHex("#008080"),
                TextColor = Color.White,
                Text = "End this Trail"
            };

          
            walksHomeButton.Clicked += (sender, e) =>
            {
                if (walkItem == null) return;
                Navigation.PopToRootAsync(true);
                walkItem = null;
            };

            this.Content = new ScrollView
            {
                Padding = 10,
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children = {
                    trailMap,
                    trailNameLabel,
                    trailDistanceTravelledLabel,
                    totalTimeTakenLabel,
                    walksHomeButton
                    }
                }
            };
        }
    }
}