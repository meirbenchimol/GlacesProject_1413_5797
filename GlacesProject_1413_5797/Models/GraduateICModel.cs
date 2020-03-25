using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;





namespace PL.Models
{
    public class GraduateICModel
    {
        public Bl myBl { get; set; }


        public IceCream IceCream { get; set; }

        public GraduateICModel()
        {
            myBl = new Bl();
            IceCream = new IceCream();
        }


        public void UpdateIceCream(IceCream pre_iceCream,IceCream current_iceCream)
        {
            myBl.UpdateIceCream(pre_iceCream, current_iceCream);
        }

    }
}
