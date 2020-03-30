using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
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

        public List<String> Images
        {
            get { return images;}
        }

        private List<IceCream> products= new List<IceCream>();

        public List<IceCream> Products
        {
            get { return products; }
        }


        public bool ShopTaste(string taste)
        {
            for(int i=0;i<=products.Count;i++)
            {
                if (products[i].taste.Contains(taste))
                    return true;

            }

            return false;
            
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
            products.Add(new IceCream());
            products.Add(new IceCream());
            products.Add(new IceCream());
            images.Add("shopIcon.png");


        }

    }
}
