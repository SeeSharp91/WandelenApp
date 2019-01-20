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
		public voorgesteldeRoutes ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing ()
        {
            base.OnAppearing();
            voorgesteldeRoutesListView.ItemsSource = await App.RouteManager.GetTaskAsync();
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var routeitem = e.SelectedItem as Route;
            var previewkaart = new previewRoute();
            previewkaart.BindingContext = routeitem;
            Navigation.PushAsync(previewkaart);
        }

        private void onStartRoute_clicked(object sender, EventArgs e)
        {

        }

        private void onDownloadRoute_clicked(object sender, EventArgs e)
        {

        }

        private void onGeefReview_clicked(object sender, EventArgs e)
        {

        }

        private void onGeefBeoordeling_clicked(object sender, EventArgs e)
        {

        }
    }
}