using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelesExpidia.Controllers
{
    public class RoomController : ApiController
    {
        public string Get(string arrivalDate, string departureDate, string room1)
        {
            WebClient clienteTom = new WebClient();
            string respuesta = clienteTom.DownloadString("http://dev.api.ean.com/ean-services/rs/hotel/v3/avail?cid=55505&minorRev=99&apiKey=cbrzfta369qwyrm9t5b8y8kf&locale=en_US&currencyCode=USD&hotelId=106347&arrivalDate=12/20/2014&departureDate=12/22/2014&includeDetails=true&room1=2&_type=json");
            return respuesta;
        }
    }
}
