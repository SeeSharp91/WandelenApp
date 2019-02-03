using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Wandelen.Data;
using SQLite.Net.Interop;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Wandelen
{
    public partial class App : Application
    {
        public static RouteItemsManager RouteManager { get; private set; }
        public static ISQLitePlatform DatabaseLocation { get; internal set; }
        public static string DBLocation = string.Empty;

        public static double ScreenHeight;
        public static double ScreenWidth;

        public App()
        {
            InitializeComponent();
            RouteManager = new RouteItemsManager(new RestService());
            MainPage = new NavigationPage(new LoginPage());
        }
        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DBLocation = databaseLocation;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
