using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace PL.Models
{
    public class LoginModel
    {
        public Shop CurrentShop { get; set; }

        public Bl MyBl { get; set; }


        public bool findShopByLogin(string id, string password)
        {
            Shop shop = MyBl.findShopByLogin(id, password);

            if (shop == null)
                return false;
            else
            {
                CurrentShop = shop;
                return true;
            }


        }
    }
}
