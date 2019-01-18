using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutePage : ContentPage
    {
        public static ObservableCollection<string> items { get; set; }
        public RoutePage()
        {
            items = new ObservableCollection<string>() { "Route Samenstellen", "Voorgestelde Routes", "Mijn Routes" };
            InitializeComponent();
        }
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
        }

        void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            //put your refreshing logic here
            var itemList = items.Reverse().ToList();
            items.Clear();
            foreach (var s in itemList)
            {
                items.Add(s);
            }
            //make sure to end the refresh state
            list.IsRefreshing = false;
        }
        void GaNaarKaart(object sender, EventArgs e)
        {
            var item = (MenuItem)sender;
            Navigation.PushAsync(new KaartPage());
        }
    }
}