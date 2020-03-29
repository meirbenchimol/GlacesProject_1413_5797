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
using System.Windows.Shapes;
using PL.ViewModel;
using BE;


namespace PL.Views
{
    /// <summary>
    /// Interaction logic for ShopAreaUC.xaml
    /// </summary>
    public partial class ShopAreaUC  
    {
        public Shop Shop { get; set; }
        public ShopAreaVM shopAreaVM { get; set; }

        public ShopAreaUC(Shop shop)
        {
            InitializeComponent();
            Shop = shop;
            shopAreaVM = new ShopAreaVM(this);
            this.DataContext = shopAreaVM;

        }
    }
}
