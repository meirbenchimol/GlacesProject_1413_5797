using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Linq;
using BE;
using BL;
using Geocoding;
using Geocoding.Google;
using GoogleMaps.LocationServices;


namespace PL.Models
{
    public class IceCreamShopModel
    {

        public Shop shop { get; set; }
        public IceCream iceCream { get; set; }
        public Bl bl { get; set; }


        public IceCreamShopModel()
        {
            bl = new Bl();
            iceCream = new IceCream();
            shop = new Shop();

        }
        

 
        public string GetGpsAddress(string address)
        {
            string gpsAddress = "";

            //string requestUri = "https://maps.googleapis.com/maps/api/geocode/json?address=YourAdress&key=YourApiKey";
            //WebRequest request = WebRequest.Create(requestUri);
            //WebResponse response = request.GetResponse();
            //XDocument xdoc = XDocument.Load(response.GetResponseStream());
            //XElement result = xdoc.Element("GeocodeResponse").Element("result");
            //XElement locationElement = result.Element("geometry").Element("location");
            //XElement lat = locationElement.Element("lat");
            //XElement lng = locationElement.Element("lng");
            //gpsAddress = lat.ToString() + "," + lng.ToString();

            // the code above allows to recover the coordinates gps of an address with the API of google but for
            //security reasons we will use a specific code to see the performance of our application 

            switch (address)
            {
                case "17 Avenue des Champs-Élysées, Paris, France":
                    gpsAddress = "48.86928176879883,2.3089842796325684";
                    break;
                case "Jaffa Street 15, Jérusalem, Israël":
                    gpsAddress = "31.788742065429688,35.20229721069336";
                    break;
                case "Hapisgah Street 21, Jérusalem, Israël":
                case "21 Hapisga Jerusalem":
                    gpsAddress = "31.768224716186523,35.18291473388672";
                    break;
                case "Havaad Haleumi Street 21, Jérusalem, Israël":
                case "Mahon lev":
                default:
                    gpsAddress = "31.765291213989258,35.19132614135742";
                    break;

            }

            return gpsAddress;
        }

     


    }
}
