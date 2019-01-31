using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wandelen.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutePage : ContentPage
    {
        public RoutePage()
        {
            InitializeComponent();
            //Misschien gebruik maken van buttons?
        }

        private void voorgestelderoutes_clicked(object sender, EventArgs e)
        {
            var routepagina = new voorgesteldeRoutes();
            Navigation.PushAsync(routepagina);
        }

        private void RouteKiezen_Clicked(object sender, EventArgs e)
        {

        }

        private void RouteMaken_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EigenRoutePage());
        }
    }
}