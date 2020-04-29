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

        public SearchIceCreamUC SearchIceCreamUC { get; set; }
        public GraduationUC GraduationUC { get; set; }
        public ProfileBarIceCreamUC ProfileBarIceCreamUC { get; set; }

        public IceCreamShopUC(Shop shop,IceCream iceCream)
        {
            InitializeComponent();
            this.shop = shop;
            this.iceCream = iceCream;
            this.IceCreamShopVM = new IceCreamShopVM(this);
            this.DataContext = IceCreamShopVM;
           // this.ImageViewIceCream.ItemsSource = IceCreamShopVM.C

        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            SearchIceCreamUC = new SearchIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).full_content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(SearchIceCreamUC);



        }

        private void Graduate_btn_Click(object sender, RoutedEventArgs e)
        {
            GraduationUC = new GraduationUC(iceCream);
            ProfileBarIceCreamUC = new ProfileBarIceCreamUC(iceCream);
            ((MainWindow)System.Windows.Application.Current.MainWindow).full_content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(GraduationUC);
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Add(ProfileBarIceCreamUC);
        }
    }
}
