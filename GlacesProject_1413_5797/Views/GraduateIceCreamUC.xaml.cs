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
using BL;
using BE;

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour GraduateIceCreamUC.xaml
    /// </summary>
    public partial class GraduateIceCreamUC : UserControl
    {

        public Bl MyBl { get; set; }
        public GraduateIceCreamUC()
        {
            
            InitializeComponent();
            MyBl = new Bl();
            IceCreamComboBox.ItemsSource = MyBl.GetAllIceCream();
            IceCreamComboBox.DisplayMemberPath = "Presentation";
            IceCreamComboBox.SelectedValuePath = "ID";
            ShopComboBox.IsEnabled = false;
        }

        private void IceCream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IceCream selectedIC = IceCreamComboBox.SelectedItem as IceCream;
            ShopComboBox.ItemsSource = MyBl.GetAllShop(x => x.Products.Contains(selectedIC));
            IceCreamComboBox.DisplayMemberPath = "ID";
            IceCreamComboBox.SelectedValuePath = "ID";
            ShopComboBox.IsEnabled = true;
        }

        private void Graduate(object sender, RoutedEventArgs e)
        {

        }
    }
}
