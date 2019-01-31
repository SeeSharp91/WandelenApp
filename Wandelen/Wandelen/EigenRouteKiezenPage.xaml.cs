using Wandelen.Models;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EigenRouteKiezenPage : ContentPage
	{
		public EigenRouteKiezenPage ()
		{
			InitializeComponent ();
            using (SQLiteConnection conn = new SQLiteConnection(App.DBLocation))
            {
                var routes = conn.Query<Route>("SELECT route_naam FROM Route");
                routeListview.ItemsSource = routes;
            }

        }

    }
}