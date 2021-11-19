using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;
using myGoogleMapApp1.ViewModels;

namespace myGoogleMapApp1.ViewModels
{
    class MapPageViewModel
    {

        public class StreetNames
        {
            public string Latitude { get; set; }
            public string Longitude { get; set; }
            public string ServiceDay { get; set;}
            public string Address { get; set; }
        }
        internal async Task<List<StreetNames>> LoadStreets()
        {
            List<StreetNames> streetNames = new List<StreetNames>
        {
            new StreetNames { Latitude = "59.385826", Longitude = "17.918684", ServiceDay = "fredag", Address="Norra vägen" },
            new StreetNames { Latitude = "59.386474", Longitude = "17.909433", ServiceDay = "onsdag", Address="Torpstugegränd" },
            new StreetNames { Latitude = "59.389632", Longitude = "17.927024", ServiceDay = "onsdag", Address="Rinkebystråket" },
            new StreetNames { Latitude = "59.389932", Longitude = "17.927419", ServiceDay = "onsdag", Address="Rinkebystråket"},
            new StreetNames { Latitude = "59.389262", Longitude = "17.928852", ServiceDay = "måndag", Address="Hinderstorps gränd"},
            new StreetNames { Latitude = "59.382272", Longitude = "17.922927", ServiceDay = "måndag", Address="Stenbygränd" },
            new StreetNames { Latitude = "59.384788", Longitude = "17.916908", ServiceDay = "onsdag", Address="Båtmans Stens väg" },
            new StreetNames { Latitude = "59.383192", Longitude = "17.919297", ServiceDay = "tisdag", Address="Bromstens Brink" }
        };
            return streetNames;
        }
    }
}