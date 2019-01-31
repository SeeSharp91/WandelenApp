using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Wandelen.Models
{
    public class test : ContentPage
    {
        //tijdelijk klasse wordt verwijderd bij oplevering
        public ListView _listView;
        private Button testb;
        public test()
        {
            this.Title = "Gebruikers";
            string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WandelappDB.db3");

            var db = new SQLiteConnection(_dbPath);

            StackLayout stacklayout = new StackLayout();
            _listView = new ListView();
            _listView.ItemsSource = db.Table<Wandelaar>().ToList();
            stacklayout.Children.Add(_listView);

            Content = stacklayout;

            testb = new Button();
            testb.Text = "test";
            testb.Clicked += testb_Clicked;
            stacklayout.Children.Add(testb);



            Content = stacklayout;
        }

        private async void testb_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new LoginPage());

            }
            catch
            {
                await DisplayAlert(null, "Maak eerst een account aan" + " Geen account", "Ok");
            }
        }
    }
}