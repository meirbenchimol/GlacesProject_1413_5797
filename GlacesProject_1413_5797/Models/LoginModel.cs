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

        public ProfileBarUC profileBarUC;

        public Bl MyBl { get; set; }

  
        public LoginModel()
        {
            MyBl = new Bl();
            

        }

        public bool findShopByLogin(string id, string password)
        {
            Shop shop = MyBl.findShopByLogin(id, password);

            if (shop == null)
                return false;
            else
            {
                shop.UpdateLists();
                shopAreaUC = new ShopAreaUC(shop.Id);
                profileBarUC = new ProfileBarUC(shop);
                ((MainWindow)System.Windows.Application.Current.MainWindow).mainVM.UpdateShop(shop);
                ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
                ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
                ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();

                ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);
                ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Add(profileBarUC);
                return true;
            }


        }
    }
}
