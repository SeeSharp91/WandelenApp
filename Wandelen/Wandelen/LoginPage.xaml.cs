//using Android.Widget;
using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public bool IsToggled { get; set; }


        public LoginPage ()
		{
			InitializeComponent ();
		}

        private void Inloggen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        private void WachtwoordVergeten_Clicked(object sender, EventArgs e)
        {
            //
        }

        

        private void OnthoudenGebruiker_Switch_Toggled(object sender, ToggledEventArgs e)
        {
        //    if (IsToggled == true)
        //    {
        //        //string RememberMe = "Uw naam wordt onthouden";
        //        Toast.MakeText(Android.App.Application.Context, "Uw naam wordt onthouden!", ToastLength.Long).Show();
        //    }
        //    else
        //    {
        //        //string ForgetMe = "U bent vergeten";
        //        Toast.MakeText(Android.App.Application.Context, "U bent vergeten", ToastLength.Long).Show();
        //    }
        }
    }
}