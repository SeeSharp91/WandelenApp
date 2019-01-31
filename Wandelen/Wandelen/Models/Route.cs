using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wandelen.Models
{
    public class Route
    {
        [PrimaryKey, AutoIncrement]
        public int route_id { get; set; }

        [MaxLength(250)]
        public string route_naam { get; set; }
        public string route_plaatsnaam { get; set; }
        public string route_moeilijkheidsgraad { get; set; }        
        public string route_review { get; set; }
        public int route_rating { get; set; }
        public int route_tijd { get; set; }    

    }
}
