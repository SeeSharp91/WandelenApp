using System;
using System.Collections.Generic;
using System.Text;

namespace Wandelen.Models
{
    public class Route
    {

        public int route_id { get; set; }
        public string route_naam { get; set; }
        public string route_plaatsnaam { get; set; }
        public string route_moeilijkheidsgraad { get; set; }
        public string route_review { get; set; }
        public int route_rating { get; set; }
        public int route_tijd { get; set; }
 


        public Route()
        {

        }
        public void EigenRoutesOphalen()
        {

        }
        //public void OpslaanRoute(idRoute: int, naamRoute: string,
        //                         lengteRoute: double, tijdRoute: Datetime,
        //                         moeilijkheidsGraad: string, wegbewijzering: bool)
        //{
        //}

        //public void WijzigRoute(idRoute: int, naamRoute: string,
        //            lengteRoute: double, tijdRoute: Datetime,
        //            moeilijkheidsGraad: string, wegbewijzering: bool)
        //{
        //}

        //public void VerwijderRoute(idRoute: int, naamRoute: string,
        //            lengteRoute: double, tijdRoute: Datetime,
        //            moeilijkheidsGraad: string, wegbewijzering: bool)
        //{
        //}

    }
}
