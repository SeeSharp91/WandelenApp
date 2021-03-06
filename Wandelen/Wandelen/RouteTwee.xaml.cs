﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RouteTwee : ContentPage
	{
		public RouteTwee ()
		{
            var customMap = new CustomMap
            {
                MapType = MapType.Street,
                IsShowingUser = true,
                WidthRequest = App.ScreenWidth,
                HeightRequest = App.ScreenHeight
            };


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
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98965, latitude: 50.94355));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98967, latitude: 50.94352));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98956, latitude: 50.94337));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98957, latitude: 50.94323));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98954, latitude: 50.94319));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98935, latitude: 50.94311));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98919, latitude: 50.943));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98912, latitude: 50.94289));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98906, latitude: 50.94271));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98891, latitude: 50.94254));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98887, latitude: 50.94246));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98891, latitude: 50.94245));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98896, latitude: 50.94241));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98901, latitude: 50.94232));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98899, latitude: 50.94219));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98901, latitude: 50.9421));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98918, latitude: 50.94178));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98923, latitude: 50.94155));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98923, latitude: 50.9414));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9892, latitude: 50.94131));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98888, latitude: 50.94112));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98874, latitude: 50.94096));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98865, latitude: 50.9408));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98864, latitude: 50.94068));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98867, latitude: 50.94062));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98886, latitude: 50.94046));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9891, latitude: 50.94031));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98928, latitude: 50.94024));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9895, latitude: 50.9401));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98973, latitude: 50.93992));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99038, latitude: 50.9397));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99044, latitude: 50.93964));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99068, latitude: 50.9395));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99074, latitude: 50.9395));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99092, latitude: 50.93947));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99106, latitude: 50.93937));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99131, latitude: 50.93926));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99145, latitude: 50.9393));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99161, latitude: 50.93932));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99168, latitude: 50.93931));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99178, latitude: 50.93926));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.992, latitude: 50.9391));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99211, latitude: 50.93908));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99243, latitude: 50.9391));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99255, latitude: 50.93909));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9928, latitude: 50.93903));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99306, latitude: 50.93905));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99325, latitude: 50.939));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9933, latitude: 50.939));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99333, latitude: 50.93897));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99348, latitude: 50.93893));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99347, latitude: 50.93891));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99333, latitude: 50.93887));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99335, latitude: 50.93883));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99352, latitude: 50.9388));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99367, latitude: 50.93868));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99381, latitude: 50.93866));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.994, latitude: 50.93863));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99398, latitude: 50.93862));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99371, latitude: 50.93859));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99378, latitude: 50.93852));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99373, latitude: 50.93844));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99376, latitude: 50.93842));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9939, latitude: 50.9384));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99389, latitude: 50.93838));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99367, latitude: 50.93839));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99339, latitude: 50.93835));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99339, latitude: 50.93824));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99335, latitude: 50.93821));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99334, latitude: 50.93813));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99207, latitude: 50.93825));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99139, latitude: 50.93839));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99082, latitude: 50.93858));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99065, latitude: 50.93865));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99053, latitude: 50.93853));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99047, latitude: 50.93851));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99035, latitude: 50.93851));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99021, latitude: 50.93846));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99024, latitude: 50.9384));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99038, latitude: 50.93832));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99072, latitude: 50.93825));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99159, latitude: 50.93813));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99246, latitude: 50.93804));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99303, latitude: 50.93799));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99559, latitude: 50.93774));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99563, latitude: 50.93741));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99572, latitude: 50.93714));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99589, latitude: 50.93694));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9961, latitude: 50.93653));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99645, latitude: 50.93645));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99674, latitude: 50.93628));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99701, latitude: 50.93603));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99706, latitude: 50.93585));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99692, latitude: 50.93565));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99737, latitude: 50.93514));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99781, latitude: 50.93502));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99858, latitude: 50.93431));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99885, latitude: 50.9342));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.999, latitude: 50.93414));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99915, latitude: 50.93397));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99885, latitude: 50.93395));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99881, latitude: 50.93388));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99867, latitude: 50.93382));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99855, latitude: 50.9337));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99852, latitude: 50.93318));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99858, latitude: 50.93294));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99858, latitude: 50.93251));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99842, latitude: 50.9317));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99827, latitude: 50.93152));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9977, latitude: 50.93123));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99743, latitude: 50.93097));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99714, latitude: 50.93064));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99728, latitude: 50.93055));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99747, latitude: 50.9303));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99757, latitude: 50.93017));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99787, latitude: 50.93004));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99811, latitude: 50.92974));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99814, latitude: 50.92967));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99792, latitude: 50.92949));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99789, latitude: 50.92944));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99822, latitude: 50.92929));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99854, latitude: 50.92918));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99875, latitude: 50.92923));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99908, latitude: 50.92935));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9991, latitude: 50.92947));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99973, latitude: 50.92941));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00359, latitude: 50.92913));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00438, latitude: 50.92913));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.0047, latitude: 50.92916));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00491, latitude: 50.92922));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00504, latitude: 50.92922));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.0051, latitude: 50.92918));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00521, latitude: 50.929));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00534, latitude: 50.92878));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00539, latitude: 50.9285));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00536, latitude: 50.92824));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00526, latitude: 50.92802));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00504, latitude: 50.92774));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00493, latitude: 50.92735));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00499, latitude: 50.92698));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00503, latitude: 50.92687));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00509, latitude: 50.92679));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00525, latitude: 50.92666));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00555, latitude: 50.92654));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00583, latitude: 50.92649));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00604, latitude: 50.92649));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00623, latitude: 50.92652));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00629, latitude: 50.92607));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00636, latitude: 50.92594));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00637, latitude: 50.92571));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00646, latitude: 50.92546));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00614, latitude: 50.92505));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00592, latitude: 50.92489));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00562, latitude: 50.92443));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00548, latitude: 50.92394));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00539, latitude: 50.92382));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00515, latitude: 50.92362));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00512, latitude: 50.92349));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00518, latitude: 50.92349));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00512, latitude: 50.92349));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00406, latitude: 50.92382));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00301, latitude: 50.92423));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00239, latitude: 50.92444));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00138, latitude: 50.92482));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00059, latitude: 50.92509));
            customMap.RouteCoordinates.Add(new Position(longitude: 6.00037, latitude: 50.92494));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99982, latitude: 50.92454));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99911, latitude: 50.92423));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99875, latitude: 50.92411));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99854, latitude: 50.92401));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99823, latitude: 50.92395));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99816, latitude: 50.92391));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99811, latitude: 50.92385));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99635, latitude: 50.92268));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99599, latitude: 50.92242));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99585, latitude: 50.92244));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99547, latitude: 50.92253));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99531, latitude: 50.92255));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99507, latitude: 50.92254));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99482, latitude: 50.92252));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99459, latitude: 50.92255));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99417, latitude: 50.92268));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99414, latitude: 50.92263));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99417, latitude: 50.92268));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99413, latitude: 50.92295));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99409, latitude: 50.9231));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99393, latitude: 50.92331));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99382, latitude: 50.92341));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99381, latitude: 50.92347));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99362, latitude: 50.92368));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99339, latitude: 50.92404));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99439, latitude: 50.92465));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99443, latitude: 50.92471));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99453, latitude: 50.92497));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99454, latitude: 50.92525));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99486, latitude: 50.92553));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99497, latitude: 50.92567));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9951, latitude: 50.92578));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99515, latitude: 50.92588));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99521, latitude: 50.92606));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99536, latitude: 50.92629));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99535, latitude: 50.92633));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99534, latitude: 50.92637));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99516, latitude: 50.92656));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99511, latitude: 50.92667));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99511, latitude: 50.92686));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99498, latitude: 50.92711));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99498, latitude: 50.92716));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99513, latitude: 50.92722));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99569, latitude: 50.9275));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99554, latitude: 50.92763));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9953, latitude: 50.92773));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99457, latitude: 50.92794));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9938, latitude: 50.92823));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99368, latitude: 50.9283));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99338, latitude: 50.92831));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99307, latitude: 50.92831));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9927, latitude: 50.92827));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99221, latitude: 50.92815));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99184, latitude: 50.92813));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99123, latitude: 50.92802));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98929, latitude: 50.92762));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98855, latitude: 50.92792));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98789, latitude: 50.92807));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98705, latitude: 50.92811));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98676, latitude: 50.9281));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98645, latitude: 50.92814));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98603, latitude: 50.9282));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98633, latitude: 50.92833));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98654, latitude: 50.92851));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98686, latitude: 50.92884));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98695, latitude: 50.92899));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98703, latitude: 50.9293));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98709, latitude: 50.93003));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98709, latitude: 50.93009));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98733, latitude: 50.93025));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98732, latitude: 50.93047));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98758, latitude: 50.93048));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98795, latitude: 50.93059));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98802, latitude: 50.93098));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98829, latitude: 50.93107));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98847, latitude: 50.93117));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98852, latitude: 50.93138));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98835, latitude: 50.93162));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98826, latitude: 50.93206));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98783, latitude: 50.93233));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9883, latitude: 50.93316));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9883, latitude: 50.93321));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98852, latitude: 50.9338));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98868, latitude: 50.93397));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98886, latitude: 50.93406));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9894, latitude: 50.93442));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98963, latitude: 50.93478));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98992, latitude: 50.93508));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99034, latitude: 50.93543));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99048, latitude: 50.9359));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99048, latitude: 50.93602));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99038, latitude: 50.93622));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99033, latitude: 50.93637));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99036, latitude: 50.9365));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99053, latitude: 50.93681));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9907, latitude: 50.9369));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99108, latitude: 50.93702));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99134, latitude: 50.93705));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99169, latitude: 50.93704));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99239, latitude: 50.93689));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99261, latitude: 50.9369));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99272, latitude: 50.93695));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99277, latitude: 50.93699));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99272, latitude: 50.93733));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99277, latitude: 50.93747));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99297, latitude: 50.93783));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99303, latitude: 50.93799));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99246, latitude: 50.93804));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99159, latitude: 50.93813));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99072, latitude: 50.93825));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99038, latitude: 50.93832));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99024, latitude: 50.9384));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99021, latitude: 50.93846));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99035, latitude: 50.93851));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99047, latitude: 50.93851));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99053, latitude: 50.93853));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99067, latitude: 50.93867));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99064, latitude: 50.93877));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.99049, latitude: 50.93889));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98988, latitude: 50.9391));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98968, latitude: 50.93928));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98946, latitude: 50.93938));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98929, latitude: 50.93957));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98914, latitude: 50.93973));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98907, latitude: 50.93978));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9889, latitude: 50.93985));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98858, latitude: 50.93997));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9885, latitude: 50.94001));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98842, latitude: 50.9401));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98821, latitude: 50.94019));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98797, latitude: 50.94034));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98773, latitude: 50.94042));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98762, latitude: 50.94048));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98754, latitude: 50.94066));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98755, latitude: 50.94078));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98766, latitude: 50.94092));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98794, latitude: 50.94111));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98849, latitude: 50.94133));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98862, latitude: 50.94143));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98874, latitude: 50.94159));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98878, latitude: 50.9417));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98878, latitude: 50.94176));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98863, latitude: 50.94202));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98859, latitude: 50.94213));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98864, latitude: 50.94234));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9887, latitude: 50.9424));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98887, latitude: 50.94246));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98891, latitude: 50.94254));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98906, latitude: 50.94271));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98912, latitude: 50.94289));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98919, latitude: 50.943));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98935, latitude: 50.94311));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98954, latitude: 50.94319));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98957, latitude: 50.94323));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98956, latitude: 50.94337));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98967, latitude: 50.94352));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98965, latitude: 50.94355));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98893, latitude: 50.94336));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98877, latitude: 50.94335));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98815, latitude: 50.94314));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98799, latitude: 50.94306));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98801, latitude: 50.94301));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98791, latitude: 50.94286));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.9878, latitude: 50.94276));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98734, latitude: 50.94253));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98717, latitude: 50.94248));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98525, latitude: 50.9436));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98451, latitude: 50.94405));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98443, latitude: 50.94412));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98422, latitude: 50.94447));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98413, latitude: 50.94466));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.984, latitude: 50.94511));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98389, latitude: 50.94548));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98432, latitude: 50.94573));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98468, latitude: 50.94583));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98483, latitude: 50.94585));
            customMap.RouteCoordinates.Add(new Position(longitude: 5.98506, latitude: 50.94585));
            


            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(50.94585, 5.98506), Distance.FromMeters(200)));
            Content = customMap;
        }
	}
}