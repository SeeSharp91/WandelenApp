using Wandelen.Models;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Collections.Generic;

namespace Wandelen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EigenRouteKiezenPage : ContentPage
	{        
        public EigenRouteKiezenPage ()
		{
			InitializeComponent ();
            GetData();
        }

        public void GetData()
        {
            Route newRoute1 = new Route()
            {
                route_naam = "TEST DB connection"
            };
            Route newRoute2 = new Route()
            {
                route_naam = "Rondje Dalenbroeck"
            };
            Route newRoute3 = new Route()
            {
                route_naam = "De wonderen van Herkenbosch"
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DBLocation))
            {
                conn.CreateTable<Route>();
                int rows1 = conn.Insert(newRoute1);
                int rows2 = conn.Insert(newRoute2);
                int rows3 = conn.Insert(newRoute3);

                var routes = conn.Table<Route>().ToList();
                routeListView.ItemsSource = routes;
            }
        }
        public void RefreshData()
        {
            Route newRoute2 = new Route()
            {
                route_naam = "Rondje Dalenbroeck"
            };
            Route newRoute3 = new Route()
            {
                route_naam = "De wonderen van Herkenbosch"
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DBLocation))
            {
                conn.CreateTable<Route>();
                int rows2 = conn.Insert(newRoute2);
                int rows3 = conn.Insert(newRoute3);

                var routes = conn.Table<Route>().ToList();
                routeListView.ItemsSource = routes;
            }
        }

        private void btnDelete_Clicked(object sender, System.EventArgs e)
        {
            string query = "DELETE route_naam FROM Route WHERE route_naam = TEST DB connection";

            using (SQLiteConnection conn = new SQLiteConnection(App.DBLocation))
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = query;
            }
            DisplayAlert("Success", "Route succesfully deletet.", "ok");
            RefreshData();
        }
    }
}