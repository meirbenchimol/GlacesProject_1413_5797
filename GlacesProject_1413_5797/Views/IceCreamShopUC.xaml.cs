using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
using PL.ViewModel;

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour IceCreamShopUC.xaml
    /// </summary>
    public partial class IceCreamShopUC : UserControl
    {
        public Shop shop { get; set; }

        public IceCream iceCream { get; set; }

        public IceCreamShopVM IceCreamShopVM { get; set; }


        public IceCreamShopUC(Shop shop,IceCream iceCream)
        {
            InitializeComponent();
            this.shop = shop;
            this.iceCream = iceCream;
            this.IceCreamShopVM = new IceCreamShopVM(this);
            this.DataContext = IceCreamShopVM;

        }

        private void Bnt_return_Click(object sender, RoutedEventArgs e)
        {

        }

        private void graduate_return_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void graduate_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
