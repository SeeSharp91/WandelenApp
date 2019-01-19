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

            //customMap.RouteCoordinates.Add(new Position(50.947230, 5.979053));
            //customMap.RouteCoordinates.Add(new Position(50.944773, 5.981314));
            //customMap.RouteCoordinates.Add(new Position(50.946206, 5.983832));
            //customMap.RouteCoordinates.Add(new Position(50.947985, 5.979986));
            //customMap.RouteCoordinates.Add(new Position(50.949290, 5.981625));
            //customMap.RouteCoordinates.Add(new Position(50.948865, 5.979721));
            //customMap.RouteCoordinates.Add(new Position(longitude: 5.979721, latitude: 50.948865));

            customMap.RouteCoordinates.Add(new Position(longitude: 5.98506, latitude: 50.94585));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9853, latitude: 50.94584));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98553, latitude: 50.94585));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9857, latitude: 50.94593));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98588, latitude: 50.94599));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98815, latitude: 50.94499));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98825, latitude: 50.94478));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98846, latitude: 50.94448));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98876, latitude: 50.94394));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98893, latitude: 50.94336));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98886, latitude: 50.94336));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98907, latitude: 50.9434));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98965, latitude: 50.94355));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99053, latitude: 50.94371));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99063, latitude: 50.94376));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99067, latitude: 50.94384));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99055, latitude: 50.94426));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99057, latitude: 50.94431));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99084, latitude: 50.94463));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99083, latitude: 50.94474));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99062, latitude: 50.94493));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99036, latitude: 50.94519));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99035, latitude: 50.94526));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99039, latitude: 50.94537));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99038, latitude: 50.9455));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99024, latitude: 50.94565));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99029, latitude: 50.94586));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99056, latitude: 50.94599));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99166, latitude: 50.94665));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99191, latitude: 50.9468));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98999, latitude: 50.94803));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98987, latitude: 50.94811));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98985, latitude: 50.94814));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98992, latitude: 50.94822));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99095, latitude: 50.94883));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98989, latitude: 50.94953));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98966, latitude: 50.94978));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9895, latitude: 50.95001));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9893, latitude: 50.95009));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9892, latitude: 50.95017));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98921, latitude: 50.95024));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9893, latitude: 50.95032));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98956, latitude: 50.9505));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98958, latitude: 50.95053));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98961, latitude: 50.95059));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98963, latitude: 50.95071));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98961, latitude: 50.95078));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9895, latitude: 50.95089));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98923, latitude: 50.95101));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98884, latitude: 50.95109));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98868, latitude: 50.95123));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98863, latitude: 50.95129));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98858, latitude: 50.95147));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98865, latitude: 50.95154));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98876, latitude: 50.95162));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98884, latitude: 50.95173));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98884, latitude: 50.95191));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98877, latitude: 50.95218));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98843, latitude: 50.95274));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98804, latitude: 50.9531));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98784, latitude: 50.95324));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98742, latitude: 50.95375));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98735, latitude: 50.95381));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98722, latitude: 50.95383));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98648, latitude: 50.95382));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98642, latitude: 50.95387));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98627, latitude: 50.95414));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9861, latitude: 50.95452));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98607, latitude: 50.95464));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98613, latitude: 50.95486));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98613, latitude: 50.95502));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98607, latitude: 50.95513));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98592, latitude: 50.95527));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98591, latitude: 50.95534));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98624, latitude: 50.95618));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98399, latitude: 50.95654));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98381, latitude: 50.9565));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98354, latitude: 50.95649));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98349, latitude: 50.95654));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98345, latitude: 50.95672));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98336, latitude: 50.95683));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98311, latitude: 50.95683));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9831, latitude: 50.95699));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98302, latitude: 50.95728));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98294, latitude: 50.95747));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98323, latitude: 50.95755));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98336, latitude: 50.95761));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98368, latitude: 50.95785));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98375, latitude: 50.95794));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98373, latitude: 50.958));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98368, latitude: 50.95805));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98322, latitude: 50.95824));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98332, latitude: 50.95827));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9837, latitude: 50.95812));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98383, latitude: 50.95811));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98397, latitude: 50.95813));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98434, latitude: 50.95843));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98435, latitude: 50.95847));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98433, latitude: 50.95851));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98423, latitude: 50.95857));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98403, latitude: 50.95867));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98208, latitude: 50.95939));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98222, latitude: 50.95955));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98326, latitude: 50.96007));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98358, latitude: 50.96014));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98394, latitude: 50.96012));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98414, latitude: 50.96007));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98423, latitude: 50.96006));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98414, latitude: 50.96007));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98394, latitude: 50.96012));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98358, latitude: 50.96014));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9834, latitude: 50.9602));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98303, latitude: 50.96024));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98289, latitude: 50.96033));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98253, latitude: 50.96045));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98216, latitude: 50.96097));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98179, latitude: 50.96122));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98164, latitude: 50.9614));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98159, latitude: 50.96156));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98162, latitude: 50.96165));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98188, latitude: 50.96187));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98189, latitude: 50.96199));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98184, latitude: 50.96205));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98147, latitude: 50.96226));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98107, latitude: 50.9624));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98069, latitude: 50.96266));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98005, latitude: 50.96294));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9794, latitude: 50.96326));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97882, latitude: 50.96373));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97848, latitude: 50.96399));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97836, latitude: 50.96413));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97827, latitude: 50.9644));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97824, latitude: 50.96477));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97826, latitude: 50.9649));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97607, latitude: 50.96553));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97569, latitude: 50.96508));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97563, latitude: 50.96503));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97544, latitude: 50.96482));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97513, latitude: 50.96485));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97463, latitude: 50.96486));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97424, latitude: 50.96492));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97394, latitude: 50.96494));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97386, latitude: 50.96491));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97359, latitude: 50.96466));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97387, latitude: 50.96452));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97359, latitude: 50.96466));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97313, latitude: 50.96486));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97301, latitude: 50.96476));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97311, latitude: 50.96435));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97338, latitude: 50.96276));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97348, latitude: 50.96262));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97349, latitude: 50.96257));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97363, latitude: 50.96154));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97376, latitude: 50.96099));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9738, latitude: 50.96069));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97382, latitude: 50.96055));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97378, latitude: 50.96046));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97401, latitude: 50.95884));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97401, latitude: 50.95876));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97394, latitude: 50.95851));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97395, latitude: 50.95846));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97416, latitude: 50.95835));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97419, latitude: 50.9582));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97401, latitude: 50.95807));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97398, latitude: 50.95803));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97407, latitude: 50.95745));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97416, latitude: 50.95709));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97441, latitude: 50.95635));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97465, latitude: 50.95627));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97471, latitude: 50.95626));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9753, latitude: 50.95627));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97625, latitude: 50.95625));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97695, latitude: 50.95626));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9773, latitude: 50.95629));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97812, latitude: 50.95638));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97825, latitude: 50.95641));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97892, latitude: 50.95536));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97899, latitude: 50.95512));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97884, latitude: 50.95438));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97886, latitude: 50.95417));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9789, latitude: 50.95403));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9792, latitude: 50.95336));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.97987, latitude: 50.95368));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98153, latitude: 50.95448));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98204, latitude: 50.9547));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98209, latitude: 50.95459));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98262, latitude: 50.95363));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9833, latitude: 50.95255));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98338, latitude: 50.95247));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98342, latitude: 50.95246));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98348, latitude: 50.95239));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98349, latitude: 50.95221));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98354, latitude: 50.95203));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.984, latitude: 50.95111));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98404, latitude: 50.95109));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98419, latitude: 50.95094));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98433, latitude: 50.95065));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98684, latitude: 50.95005));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98683, latitude: 50.95034));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98684, latitude: 50.95005));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98653, latitude: 50.9492));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98645, latitude: 50.94904));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98619, latitude: 50.94841));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98579, latitude: 50.94727));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98544, latitude: 50.94656));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98575, latitude: 50.94612));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98588, latitude: 50.94599));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9857, latitude: 50.94593));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98553, latitude: 50.94585));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9853, latitude: 50.94584));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98506, latitude: 50.94585));


            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(50.947985, 5.979986), Distance.FromMeters(200)));
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