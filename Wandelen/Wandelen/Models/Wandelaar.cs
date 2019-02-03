using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace Wandelen.Models
{
    public class Wandelaar
    {

        [PrimaryKey, NotNull] public int id { get; set; }
        [NotNull] public string voorNaam { get; set; }
        [NotNull] public string achterNaam { get; set; }
        [NotNull] public string gebruikersnaam { get; set; }
        [NotNull] public string email { get; set; }
        [NotNull] public string wachtwoord { get; set; }
        public string straatnaam { get; set; }
        public string huisnummer { get; set; }
        public string woonplaats { get; set; }
        public string postcode { get; set; }

    }
}
