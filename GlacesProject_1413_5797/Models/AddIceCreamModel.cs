using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using DAL;



namespace PL.Models
{
    public class AddIceCreamModel
    {

        public Bl MyBl { get; set; }
        public IceCream MyIC { get; set; }

        public AddIceCreamModel()
        {
            MyIC = new IceCream();
            MyBl = new Bl();
        }


        internal bool CheckIceCream()
        {
            return MyBl.CheckIceCream(MyIC.Id,MyIC.ShopId);
        }


 
        internal void AddIceCream()
        {
            MyBl.AddIceCream(MyIC);
        }
    }
}
