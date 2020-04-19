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
        [Key, Column(Order = 0)]
        public string Id { get; set; }

        public string Password { get; set; }


        public string Adress { get; set; }

        public string Phone { get; set; }


        public static string id = "raphael";

        public String FaceBookLink { get; set; }


        public String WebSiteLink { get; set; }

        private List<String> images = new List<string>();

        public string[] Images
        {
            get { return images.ToArray(); }

            set { value = images.ToArray(); }
        }



     
        public Shop()
        {

            Id = "";
            Password = "2710";
            Adress = "";
            Phone = "058";
            WebSiteLink = "";
            FaceBookLink = "";
            images.Add("shopIcon.png");
            
        }
    }
}
