using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelesExpidia.Controllers
{
    public class HotelController : ApiController
    {
        public string Get()
        {
            WebClient clienteTom = new WebClient();
            string respuesta = clienteTom.DownloadString("https://api.eancdn.com/ean-services/rs/hotel/v3/list?apiKey=cbrzfta369qwyrm9t5b8y8kf&cid=55505&minorRev=99&locale=en_US&currencyCode=USD&_type=json&destinationString=Barranquilla,Colombia&arrivalDate=12/15/2014&departureDate=12/17/2014");
            return respuesta;
        }

        public String Get(String ciudad)
        {
            WebClient clienteTom = new WebClient();
            string respuesta = clienteTom.DownloadString("https://api.eancdn.com/ean-services/rs/hotel/v3/list?apiKey=cbrzfta369qwyrm9t5b8y8kf&cid=55505&minorRev=99&locale=en_US&currencyCode=USD&_type=json&destinationString=" + ciudad);
            return respuesta;
        }
    }
}
