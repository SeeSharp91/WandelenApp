using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wandelen.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Wandelen
{

    public partial class KaartPage : ContentPage
    {
        public KaartPage()
        {
            var customMap = new CustomMap
            {
                MapType = MapType.Street,
                IsShowingUser = true,
                WidthRequest = App.ScreenWidth,
                HeightRequest = App.ScreenHeight
            };

            // moving to heerlen
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(50.881532, 5.959280), Distance.FromMeters(400)));
            Content = customMap;
        }
    }
}