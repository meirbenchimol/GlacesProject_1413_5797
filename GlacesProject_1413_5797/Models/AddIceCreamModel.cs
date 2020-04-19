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
    public class AddIceCreamModel
    {

        public Bl MyBl { get; set; }
        public IceCream MyIC { get; set; }

        public ShopAreaUC shopAreaUC;

        public AddIceCreamModel(string shopId)
        {
            MyIC = new IceCream();
            MyIC.ShopId = shopId;
            MyBl = new Bl();
        }


        internal bool CheckIceCream()
        {
            return MyBl.CheckIceCream(MyIC.Id,MyIC.ShopId);
        }


 
        internal void AddIceCream()
        {
            MyBl.AddIceCream(MyIC);
            shopAreaUC = new ShopAreaUC(MyIC.ShopId);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);


        }
    }
}
