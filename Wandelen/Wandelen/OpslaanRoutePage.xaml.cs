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
                Route newRoute = new Route()
                {
                    route_naam = eRouteNaam.Text
                };

                using (SQLiteConnection conn = new SQLiteConnection(App.DBLocation))
                {
                    conn.CreateTable<Route>();
                    int rows = conn.Insert(newRoute);

                    if (rows > 0)
                        DisplayAlert("Success", "Route succesfully added.", "ok");
                        
                    else
                        DisplayAlert("Failure", "Failed to add route", "ok");
                }            
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}