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
            string respuesta = clienteTom.DownloadString("http://dev.api.ean.com/ean-services/rs/hotel/v3/list?apiKey=cbrzfta369qwyrm9t5b8y8kf&cid=55505&minorRev=99&locale=en_US&currencyCode=USD&_type=json&destinationString=Barranquilla,Colombia&arrivalDate=12/15/2014&departureDate=12/17/2014");
            return respuesta;
        }

        public String Get(String ciudad)
        {
            WebClient clienteTom = new WebClient();
            string respuesta = clienteTom.DownloadString("http://dev.api.ean.com/ean-services/rs/hotel/v3/list?apiKey=cbrzfta369qwyrm9t5b8y8kf&cid=55505&minorRev=28&locale=en_US&currencyCode=USD&_type=json&destinationString=" + ciudad);
            return respuesta;
        }

        public string GetHotelById(string id)
        {
            WebClient clienteTom = new WebClient();
            string respuesta = clienteTom.DownloadString("http://dev.api.ean.com/ean-services/rs/hotel/v3/info?apiKey=cbrzfta369qwyrm9t5b8y8kf&cid=55505&minorRev=99&locale=en_US&currencyCode=USD&_type=json&options=0&hotelId=" + id);
            return respuesta;
        }

        public string GetRoomById(string obj)
        {
            string strParam = "";
            string[] arr1 = obj.Split(';');
            foreach (string element in arr1)
            {                
                strParam += "&" + element;             
            }            
            WebClient clienteTom = new WebClient();
            string respuesta = clienteTom.DownloadString("https://api.eancdn.com/ean-services/rs/hotel/v3/avail?cid=55505&minorRev=28&apiKey=cbrzfta369qwyrm9t5b8y8kf&locale=en_US&currencyCode=USD&includeDetails=true&_type=json&includeRoomImages=yes" + strParam);
            return respuesta;
        }
    }
}
