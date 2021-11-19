using myGoogleMapApp1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace myGoogleMapApp1
{
    public partial class MainPage : ContentPage
    {
        MapPageViewModel mapPageViewModel ;
        public MainPage()
        {
            InitializeComponent();
            
            BindingContext = mapPageViewModel = new MapPageViewModel();
            /*
            Pin pinRinkebyTower = new Pin()
            {
                Type = PinType.Place,
                Label = "RinkebyTower",
                Address = "Almbygatan 10",
                Position = new Position(59.393296d, 17.928952d),
            };
            map.Pins.Add(pinRinkebyTower);
            */
            //map.MoveToRegion(MapSpan.FromCenterAndRadius(pinRinkebyTower.Position, Distance.FromMeters(250)));
            var positions = new Position(59.38861d, 17.92120d);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(2500)));
        }

        /*private void Map_MapClicked(object sender, Xamarin.Forms.Maps.MapClickedEventArgs e)
        {
            DisplayAlert("Koordinater ", $"Lat {e.Position.Latitude}, Long {e.Position.Longitude}", "OK");
        }
        */
        async void Button_Clicked(object sender, EventArgs e)
        {
            var contents =  await mapPageViewModel.LoadStreets();
            if (contents !=null)
            {
                foreach(var item in contents)
                {
                    Pin streetPins = new Pin()
                    {
                        Type = PinType.SearchResult,
                        Position = new Position(Convert.ToDouble(item.Latitude), Convert.ToDouble(item.Longitude)),
                        Label = item.ServiceDay,
                        Address = item.Address,
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("road-sign.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "road-sign.png", WidthRequest = 20, HeightRequest = 20 })
                    };
                    map.Pins.Add(streetPins);
                }
            }
            var positions = new Position(59.38861d, 17.92120d);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(500)));
        }
    }
}
