using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EigenRoutePage : ContentPage
	{
        private bool hasLocationPermission = false;
        public EigenRoutePage ()
		{
			InitializeComponent ();
            GetPermissions();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //Locatie van de gebruiker ophalen.
            if (hasLocationPermission)
            {
                var locator = CrossGeolocator.Current;

                locator.PositionChanged += Locator_PositionChanged;
                await locator.StartListeningAsync(TimeSpan.Zero, 100);
            }
            GetLocation();

            //Pins maken om de route te bepalen.
            locationsMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Xamarin.Forms.Maps.Position(51.153017, 6.073162),
            Distance.FromKilometers(0.5)));

            //De pins kan men maken d.m.v. de Pin class die bestaat binnen Xamarin.Forms.Maps.
            //Deze zijn hardcoded toegevoegd aan de map.
            var pin1 = new Pin
            {
                Position = new Xamarin.Forms.Maps.Position(51.153166, 6.077269),
                Label = "Pin 1",
                Address = "Locatie 1"
            };
            var pin2 = new Pin
            {
                Position = new Xamarin.Forms.Maps.Position(51.150032, 6.079093),
                Label = "Pin 2",
                Address = "Locatie 2"
            };
            var pin3 = new Pin
            {
                Position = new Xamarin.Forms.Maps.Position(51.147824, 6.071590),
                Label = "Pin 3",
                Address = "Locatie 3"
            };
            var pin4 = new Pin
            {
                Position = new Xamarin.Forms.Maps.Position(51.148938, 6.069814),
                Label = "Pin 4",
                Address = "Locatie 4"
            };
            var pin5 = new Pin
            {
                Position = new Xamarin.Forms.Maps.Position(51.151876, 6.071917),
                Label = "Pin 5",
                Address = "Locatie 5"
            };
            locationsMap.Pins.Add(pin1);
            locationsMap.Pins.Add(pin2);
            locationsMap.Pins.Add(pin3);
            locationsMap.Pins.Add(pin4);
            locationsMap.Pins.Add(pin5);
        }

        private async void GetPermissions()
        //Bij deze async methode wordt gebruik gemaakt van een await variabele. 
        //Hier worden namelijk gegevens opgevraagd gevraagt. 
        //Op deze manier kunnen we wachten op de gegevens, maar kunnen we ook verder met onze app.
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.LocationWhenInUse))
                    {
                        await DisplayAlert("Need your location", "We need to access your location", "Ok");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.LocationWhenInUse);
                    if (results.ContainsKey(Permission.LocationWhenInUse))
                    {
                        status = results[Permission.LocationWhenInUse];
                    }

                }

                if (status == PermissionStatus.Granted)
                {
                    hasLocationPermission = true;
                    locationsMap.IsShowingUser = true;
                    GetLocation();
                }
                else
                {
                    await DisplayAlert("Location denied", "You didn't give us permission to access location, so we can't show you where you are", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            CrossGeolocator.Current.StopListeningAsync();
            CrossGeolocator.Current.PositionChanged -= Locator_PositionChanged;
        }
        private void Locator_PositionChanged(object sender, PositionEventArgs e)
        {
            MoveMap(e.Position);
        }
        private async void GetLocation()
        {
            if (hasLocationPermission)
            {
                var locator = CrossGeolocator.Current;
                var position = await locator.GetPositionAsync();

                MoveMap(position);
            }
        }
        private void MoveMap(Plugin.Geolocator.Abstractions.Position position)
        {
            var center = new Xamarin.Forms.Maps.Position(position.Latitude, position.Longitude);
            var span = new Xamarin.Forms.Maps.MapSpan(center, 1, 1);
            locationsMap.MoveToRegion(span);
        }                     
        private void btnStartRoute_Clicked(object sender, EventArgs e)
        {
            //To Do
        }

        private void btnStopRoute_Clicked(object sender, EventArgs e)
        {
            //To Do
        }

        private void Opslaan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OpslaanRoutePage());
        }
    }
}