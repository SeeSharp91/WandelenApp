using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Wandelen.Models;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;


namespace Wandelen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
    {

        // initialiseren benodigde elementen
        private Label _welkomLabel;
        private Entry _emailEntry;
        private Entry _wachtwoordEntry;
        private Button _loginButton;
        private Button _accountAanmakenButton;
        //Database locatie
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WandelappDB.db3");
        
        public LoginPage()
        {
            InitializeComponent();
            //nieuw stacklayout object instantiëren
            this.Title = "Wandel App";
            StackLayout stacklayout = new StackLayout();
            stacklayout.Margin = 20;

            //welkom label
            _welkomLabel = new Label();
            _welkomLabel.Text = "Maak een account aan om gebruik te maken van de nieuwe app!";
            stacklayout.Children.Add(_welkomLabel);

            //email entry
            _emailEntry = new Entry();
            _emailEntry.Keyboard = Keyboard.Email;
            _emailEntry.Placeholder = "E-mail adres";
            stacklayout.Children.Add(_emailEntry);

            //wachtwoord entry
            _wachtwoordEntry = new Entry();
            _wachtwoordEntry.Keyboard = Keyboard.Text;
            _wachtwoordEntry.IsPassword = true;
            _wachtwoordEntry.Placeholder = "Wachtwoord";
            stacklayout.Children.Add(_wachtwoordEntry);

            //login button 
            _loginButton = new Button();
            _loginButton.Text = "Log in";
            _loginButton.Clicked += _loginButton_Clicked;
            stacklayout.Children.Add(_loginButton);

            //account aanmaken button
            _accountAanmakenButton = new Button();
            _accountAanmakenButton.Text = "Account aanmaken";
            _accountAanmakenButton.Clicked += _accountAanmakenButton_Clicked;
            stacklayout.Children.Add(_accountAanmakenButton);

            //geef de content weer
            Content = stacklayout;
        }

        //inloggen logica
        private async void _loginButton_Clicked(object sender, EventArgs e)
        {
            Wandelaar wandelaar = new Wandelaar();

            if (_emailEntry.Text != wandelaar.email && _wachtwoordEntry.Text != wandelaar.wachtwoord)
            {
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Ongeldige gegevens probeer het opnieuw!", "login fout", "ok");
            }

        }
        
        //Verifiëren van gegevens
        public bool Do_Login(string email, string wachtwoord)
        {
            Wandelaar wandelaar = new Wandelaar();
            string query = "Select Count(*) FROM wandelaar WHERE email='" + email + "' AND wachtwoord='" + wachtwoord + "'";

            using (SQLiteConnection conn = new SQLiteConnection(_dbPath))
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = query;
                var count = cmd.ExecuteScalar<int>();
                if (count > 0)
                {
                    return true;
                }

                return false;
            }
        }

        //account aanmaken scherm oproepen
        private void _accountAanmakenButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountPage());
        }
    }
}