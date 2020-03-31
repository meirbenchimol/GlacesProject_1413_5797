using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Threading.Tasks;

namespace BE
{
    public class Shop
    {
        [Key , Column(Order=0)]
        public string Id { get; set; }

        public string Password { get; set; }


        public string Adress { get; set; }

        public string Phone { get; set; }


        static string id="shop";

        public String FaceBookLink { get; set; }


        public String WebSiteLink { get; set; }

        private List<String> images = new List<string>();

        public string [] Images
        {
            get; set;
        }

      

        public IceCream [] Products
        {
            get;
            set;
        }


        


        public Shop()
        {

            Id = id;
            id += "a";
            Password = "1704";
            Adress = "8 Place de Bordeaux, Strasbourg";
            Phone = "0584226257";
            WebSiteLink = "shop.com";
            FaceBookLink = "shop fb";
            Products[0] = new IceCream();
            Products[1] = new IceCream();
            images.Add("shopIcon.png");


        }

    }
}
