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
using PL.Models;
using PL.ViewModel;
using BE;


namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour AddIceCream.xaml
    /// </summary>
    public partial class AddIceCreamUC : UserControl
    {
        public ShopAreaUC shopAreaUC;
        public string ShopId;
        public IceCream currentIceCream;
        public AddIceCreamVM AddIceCreamVM { get; set; }

        public AddIceCreamUC(string shopId)
        {
            InitializeComponent();
            ShopId = shopId;
            AddIceCreamVM = new AddIceCreamVM(this);
            this.DataContext = AddIceCreamVM;
            addIceCreamBtn.Visibility = Visibility.Visible;
            UpdateIceCreamBtn.Visibility = Visibility.Collapsed;
        }

        public AddIceCreamUC(string shopId , IceCream iceCream)
        {
            InitializeComponent();
            ShopId = shopId;
            currentIceCream = iceCream;
            AddIceCreamVM = new AddIceCreamVM(this  ,iceCream);
            this.DataContext = AddIceCreamVM;
            addIceCreamBtn.Visibility = Visibility.Collapsed;
            UpdateIceCreamBtn.Visibility = Visibility.Visible;
        }

        private void CalculeBtn_Click(object sender, RoutedEventArgs e)
        {
            attribut_grid.Visibility = Visibility.Visible;
        }

        private void Bnt_return_Click(object sender, RoutedEventArgs e)
        {
            
            shopAreaUC = new ShopAreaUC(ShopId);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);

        }

       
    }
}
