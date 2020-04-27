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
using BL;

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for ShopAreaUC.xaml
    /// </summary>
    public partial class ShopAreaUC
    {
        public Shop Shop { get; set; }
        public ShopAreaVM shopAreaVM { get; set; }
        public AddIceCreamUC addIceCreamUC;
        public Bl MyBl { get; set; }



        public ShopAreaUC(string shopId)
        {
            InitializeComponent();
            Shop = new Shop();
            Shop.Id = shopId;
            shopAreaVM = new ShopAreaVM(this);
            this.DataContext = shopAreaVM;
            MyBl = new Bl();

            //ListViewIceCreams.ItemsSource = MyBl.GetIceCreamFromShop(shopId);
            ListViewIceCream.ItemsSource = MyBl.GetIceCreamFromShop(shopId);
        }

        private void addIceCreamBtn_Click(object sender, RoutedEventArgs e)
        {
            addIceCreamUC = new AddIceCreamUC(Shop.Id);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(addIceCreamUC);
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            IceCream ic = (IceCream)((Button)sender).DataContext;
            String b = ic.Id;
            MyBl.DeleteIceCream(ic);
            ListViewIceCream.ItemsSource = MyBl.GetIceCreamFromShop(Shop.Id);
            MessageBox.Show("You have delete "+b, "Warning ", MessageBoxButton.OK, MessageBoxImage.Exclamation);


        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            IceCream ic = (IceCream)((Button)sender).DataContext;
            String b = ic.Id;
           // MessageBox.Show(b, "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            addIceCreamUC = new AddIceCreamUC(Shop.Id , ic);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(addIceCreamUC);
        }

    
        private void ListViewIceCream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IceCream ic = (IceCream)ListViewIceCream.SelectedItem as IceCream;
            string itemId = ic.Id;
            MessageBox.Show(itemId, "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }
    }
}