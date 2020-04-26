using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace PL.Models
{
    public class ProfileBarIceCreamModel
    {
        public Bl myBl { get; set; }


        public IceCream IceCream { get; set; }

        public ProfileBarIceCreamModel()
        {
            myBl = new Bl();
            IceCream = new IceCream();
        }
    }
}
