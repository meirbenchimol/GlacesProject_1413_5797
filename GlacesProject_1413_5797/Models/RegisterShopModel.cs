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
    public class RegisterShopModel
    {

        public Shop MyShop { get; set; }
        public Bl MyBl { get; set; }


        public RegisterShopModel()
        {
            MyShop = new Shop();
            MyBl = new Bl();
        }


        internal bool CheckShopExist()
        {
            return MyBl.CheckShopExist(MyShop.Id);
        }




        internal void AddShop()
        {
            MyBl.AddShop(MyShop);
        }

    }
}
