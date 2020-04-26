using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;


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
        




    }
}
