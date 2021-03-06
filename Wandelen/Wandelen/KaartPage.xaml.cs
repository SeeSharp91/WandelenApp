﻿using System;
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


    //[XamlCompilation(XamlCompilationOptions.Compile)]
    //public partial class KaartPage : ContentPage
    //{
    //    public KaartPage ()
    //    {
    //        InitializeComponent();

    //        var map = new Map(MapSpan.FromCenterAndRadius(new Position(50.947985, 5.979986), Distance.FromMeters(200)))
    //        {
    //            IsShowingUser = true,
    //            VerticalOptions = LayoutOptions.FillAndExpand
    //        };

    //        var position1 = new Position(50.947230, 5.979053);
    //        var position2 = new Position(50.944773, 5.981314);
    //        var position3 = new Position(50.946206, 5.983832);
    //        var position4 = new Position(50.947985, 5.979986);
    //        var position5 = new Position(50.949290, 5.981625);
    //        var position6 = new Position(50.948865, 5.979721);

    //        var pin1 = new Pin
    //        {
    //            Type = PinType.Place,
    //            Position = position1,
    //            Label = "POI1",
    //            Address = "street adress poi1",
    //        };

    //        var pin2 = new Pin
    //        {
    //            Type = PinType.Place,
    //            Position = position1,
    //            Label = "POI2",
    //            Address = "street adress poi2",
    //        };

    //        var pin3 = new Pin
    //        {
    //            Type = PinType.Place,
    //            Position = position1,
    //            Label = "POI3",
    //            Address = "street adress poi3",
    //        };

    //        var pin4 = new Pin
    //        {
    //            Type = PinType.Place,
    //            Position = position1,
    //            Label = "POI4",
    //            Address = "street adress poi4",
    //        };

    //        var pin5 = new Pin
    //        {
    //            Type = PinType.Place,
    //            Position = position1,
    //            Label = "POI5",
    //            Address = "street adress poi5",
    //        };

    //        var pin6 = new Pin
    //        {
    //            Type = PinType.Place,
    //            Position = position1,
    //            Label = "POI6",
    //            Address = "street adress poi6",
    //        };

    //        map.Pins.Add(pin1);
    //        map.Pins.Add(pin2);
    //        map.Pins.Add(pin3);
    //        map.Pins.Add(pin4);
    //        map.Pins.Add(pin5);
    //        map.Pins.Add(pin6);

    //        Content = map;
    //    }

    //}
}