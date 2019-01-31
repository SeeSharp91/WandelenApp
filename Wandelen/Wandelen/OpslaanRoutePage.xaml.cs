using Wandelen.Models;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OpslaanRoutePage : ContentPage
	{
		public OpslaanRoutePage ()
		{
			InitializeComponent ();
        }

        private void btnOpslaanRoute_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DBLocation))
                {
                    conn.CreateTable<Route>();
                    var newRoute = new Route();
                    newRoute.route_naam = "Mijn eigen Route";
                    conn.Insert(newRoute);
                    newRoute.route_review = "Beste route ooit! Enorm genoten van alle flora en fauna.";
                    conn.Insert(newRoute);
                    newRoute = new Route();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}