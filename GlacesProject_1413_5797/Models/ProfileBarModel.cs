using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;

namespace PL.Models
{
    public class ProfileBarModel
    {

        public Bl myBl { get; set; }

        public Shop shop { get; set; }


        public ProfileBarModel(Shop shop)
        {
            this.myBl = new Bl();
            this.shop = shop;
        }
    }

}
