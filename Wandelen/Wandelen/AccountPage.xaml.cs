using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wandelen.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccountPage : ContentPage
	{
        //initialiseren benodigde elementen
        private Entry _voornaamEntry;
        private Entry _achternaamEntry;
        private Entry _gebruikersnaamEntry;
        private Entry _emailEntry;
        private Entry _wachtwoordEntry;
        //private Entry _straatnaamEntry;
        //private Entry _huisnummerEntry;
        //private Entry _woonplaatsEntry;
        //private Entry _postcodeEntry;
        private Button _accountopslaanButton;

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WandelappDB.db3");

        public AccountPage ()
		{
			InitializeComponent ();
            this.Title = "Account Aanmaken";
            StackLayout stacklayout = new StackLayout();
            
            _voornaamEntry = new Entry();
            _voornaamEntry.Keyboard = Keyboard.Text;
            _voornaamEntry.Placeholder = "Voornaam";
            stacklayout.Children.Add(_voornaamEntry);

            _achternaamEntry = new Entry();
            _achternaamEntry.Keyboard = Keyboard.Text;
            _achternaamEntry.Placeholder = "Achternaam";
            stacklayout.Children.Add(_achternaamEntry);

            _gebruikersnaamEntry = new Entry();
            _gebruikersnaamEntry.Keyboard = Keyboard.Text;
            _gebruikersnaamEntry.Placeholder = "Gebruikersnaam";
            stacklayout.Children.Add(_gebruikersnaamEntry);

            _emailEntry = new Entry();
            _emailEntry.Keyboard = Keyboard.Email;
            _emailEntry.Placeholder = "E-mail adres";
            stacklayout.Children.Add(_emailEntry);

            _wachtwoordEntry = new Entry();
            _wachtwoordEntry.Keyboard = Keyboard.Text;
            _wachtwoordEntry.IsPassword = true;
            _wachtwoordEntry.Placeholder = "Wachtwoord";
            stacklayout.Children.Add(_wachtwoordEntry);

            //_straatnaamEntry = new Entry();
            //_straatnaamEntry.Keyboard = Keyboard.Text;
            //_straatnaamEntry.Placeholder = "Straatnaam";
            //stacklayout.Children.Add(_straatnaamEntry);

            //_huisnummerEntry = new Entry();
            //_huisnummerEntry.Keyboard = Keyboard.Text;
            //_huisnummerEntry.Placeholder = "Huisnummer";
            //stacklayout.Children.Add(_huisnummerEntry);

            //_woonplaatsEntry = new Entry();
            //_woonplaatsEntry.Keyboard = Keyboard.Text;
            //_woonplaatsEntry.Placeholder = "Woonplaats";
            //stacklayout.Children.Add(_woonplaatsEntry);

            //_postcodeEntry = new Entry();
            //_postcodeEntry.Keyboard = Keyboard.Text;
            //_postcodeEntry.Placeholder = "Postcode";
            //stacklayout.Children.Add(_postcodeEntry);

            _accountopslaanButton = new Button();
            _accountopslaanButton.Text = "Creëer Account";
            _accountopslaanButton.Clicked += _accountopslaanButton_Clicked;
            stacklayout.Children.Add(_accountopslaanButton);

            Content = stacklayout;

        }

        private async void _accountopslaanButton_Clicked(object sender, EventArgs e)
        {
            SQLiteConnection database = new SQLiteConnection(_dbPath);
            database.CreateTable<Wandelaar>();

            var maxPK = database.Table<Wandelaar>().OrderByDescending(c => c.id).FirstOrDefault();

            Wandelaar wandelaar = new Wandelaar()
            {
                id = (maxPK == null ? 1 : maxPK.id + 1),
                voorNaam = _voornaamEntry.Text,
                achterNaam = _achternaamEntry.Text,
                gebruikersnaam = _gebruikersnaamEntry.Text,
                email = _emailEntry.Text,
                wachtwoord = _wachtwoordEntry.Text,
                //straatnaam = _straatnaamEntry.Text,
                //huisnummer = _huisnummerEntry.Text,
                //woonplaats = _woonplaatsEntry.Text,
                //postcode = _postcodeEntry.Text,
            };
            database.Insert(wandelaar);
            await DisplayAlert(null, "Account succesvol aangemaakt" + " opgeslagen ", "Ok");
            await Navigation.PopAsync();
        }
    }
}