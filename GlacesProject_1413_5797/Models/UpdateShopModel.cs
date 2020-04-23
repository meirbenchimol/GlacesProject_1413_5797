using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.Views;
using BL;



namespace PL.Models
{
    public class UpdateShopModel
    {

        public Shop MyShop { get; set; }
        public Bl MyBl { get; set; }

        public ShopAreaUC shopAreaUC { get; set; }

        public ProfileBarUC profileBarUC { get; set; }


        public UpdateShopModel()
        {
            MyShop = new Shop();
            MyBl = new Bl();
        }

    }
}
