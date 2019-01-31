using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wandelen.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class voorgesteldeRoutes : ContentPage
    {
        public voorgesteldeRoutes()
        {
            InitializeComponent();
        }

        private void btn_route_een_Clicked (object sender, EventArgs e)
        {
            route2.IsVisible = false;
            route1.IsVisible = true;
            btnOpslaanView.IsVisible = true;
        }

        private void btn_route_opslaan_Clicked (object sender, EventArgs e)
        {
            DisplayAlert("Route opslaan", "De route is opgeslagen", "Ok");
        }

        private void btn_route_twee_Clicked(object sender, EventArgs e)
        {
            route1.IsVisible = false;
            route2.IsVisible = true;
            btnOpslaanView.IsVisible = true;
        }

        private void route_een_clicked(object sender, EventArgs e)
        {
            // brunssum naar schinveld
            var routepagina = new routeEen();
            Navigation.PushAsync(routepagina);

        }

        private void route_twee_clicked(object sender, EventArgs e)
        {
            // route brunssummerheide
            var routepagina = new RouteTwee();
            Navigation.PushAsync(routepagina);
        }
    }
    // Niet geïmplementeerd daar er geen tijd meer was voor de complete web API op te zetten met WCF/RESTservices. 
	//
    //
    //{
	//	public voorgesteldeRoutes ()
	//	{
	//		InitializeComponent ();
	//	}

 //       protected async override void OnAppearing ()
 //       {
 //           base.OnAppearing();
 //           voorgesteldeRoutesListView.ItemsSource = await App.RouteManager.GetTaskAsync();
 //       }

 //       void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
 //       {
 //           var routeitem = e.SelectedItem as Route;
 //           var previewkaart = new previewRoute();
 //           previewkaart.BindingContext = routeitem;
 //           Navigation.PushAsync(previewkaart);
 //       }

 //       private void onStartRoute_clicked(object sender, EventArgs e)
 //       {

 //       }

 //       private void onDownloadRoute_clicked(object sender, EventArgs e)
 //       {

 //       }

 //       private void onGeefReview_clicked(object sender, EventArgs e)
 //       {

 //       }

 //       private void onGeefBeoordeling_clicked(object sender, EventArgs e)
 //       {

 //       }
    //}
}