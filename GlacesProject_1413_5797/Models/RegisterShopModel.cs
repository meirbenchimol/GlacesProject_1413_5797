using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using DAL;
using PL.Views;

namespace PL.Models
{
    public class RegisterShopModel
    {

        public Shop MyShop { get; set; }
        public Bl MyBl { get; set; }

        public ShopAreaUC shopAreaUC { get; set; }

        public ProfileBarUC profileBarUC { get; set; }
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
            MyShop.UpdateLists();
            shopAreaUC = new ShopAreaUC(MyShop.Id);
            profileBarUC = new ProfileBarUC(MyShop);
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainVM.UpdateShop(MyShop);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Add(profileBarUC);
        }

    }
}
