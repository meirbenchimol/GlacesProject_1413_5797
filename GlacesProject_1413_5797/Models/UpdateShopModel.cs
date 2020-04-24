using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.Views;
using BL;
using System.Windows;

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

        public void UpdateShop(Shop updateShop , Shop currentShop)
        {
            MyBl.UpdateShop(updateShop, currentShop);
            shopAreaUC = new ShopAreaUC(updateShop.Id);
            profileBarUC = new ProfileBarUC(updateShop);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();

            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Add(profileBarUC);
        }

    }
}
