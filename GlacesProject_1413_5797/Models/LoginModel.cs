using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using PL.ViewModel;
using PL.Views;

namespace PL.Models
{
    public class LoginModel
    {
        public Shop CurrentShop { get; set; }

        public ShopAreaUC shopAreaUC;

        public Bl MyBl { get; set; }

  
        public LoginModel()
        {
            MyBl = new Bl();
           // CurrentShop = new Shop();
           // MyBl.AddShop(CurrentShop);

        }

        public bool findShopByLogin(string id, string password)
        {
            Shop shop = MyBl.findShopByLogin(id, password);

            if (shop == null)
                return false;
            else
            {
                shopAreaUC = new ShopAreaUC(shop);
                CurrentShop = shop;
                ((MainWindow)System.Windows.Application.Current.MainWindow).mainVM.UpdateShop(shop);
                ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
                ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(shopAreaUC);
                return true;
            }


        }
    }
}
