using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
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

            //var locationService = new GoogleLocationService();
            //var point = locationService.GetLatLongFromAddress(address);

            //var latitude = point.Latitude;
            //var longitude = point.Longitude;


            ///* Call This*/
            //gpsAddress = latitude + "," + longitude;

            //string url = "https://maps.googleapis.com/maps/api/directions/json?origin=" + address + "&key=AMU";

            //WebRequest request = WebRequest.Create(url);

            //WebResponse response = request.GetResponse();

            //Stream data = response.GetResponseStream();

            //StreamReader reader = new StreamReader(data);

            //// json-formatted string from maps api
            //string responseFromServer = reader.ReadToEnd();

            //response.Close();

            return gpsAddress;
        }


    }
}
