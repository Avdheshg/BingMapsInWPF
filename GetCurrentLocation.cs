using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geolocation;
using Xamarin.Essentials;

//using System.Device.Location;

/*

Why Geolocation: https://learn.microsoft.com/en-us/answers/questions/773690/where-is-system-device-location
                https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device/geolocation?view=net-maui-8.0&tabs=windows
 
*/

namespace GoogleMapsInWPF
{
    public class GetCurrentLocation
    {
        private CancellationTokenSource _cancellationTokenSource;
        private bool _isCheckingLocation;

        public string CurrentLatitude { get; set; }
        public string CurrentLongitude { get; set; }

        public async Task GetLocationProperty()
        {
            _isCheckingLocation = true;

            GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

            _cancellationTokenSource = new CancellationTokenSource();

            //Location location = await Geolocation

        }

    }
}
