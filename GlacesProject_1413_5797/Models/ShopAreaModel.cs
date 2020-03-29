using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;

namespace PL.Models
{
    public class ShopAreaModel
    {
        public Bl  myBl { get; set; }

        public Shop shop { get; set; }


        public ShopAreaModel(Shop shop)
        {
            this.myBl = new Bl();
            this.shop = shop;
        }
        






    }
}
