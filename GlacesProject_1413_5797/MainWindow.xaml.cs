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
using PL.Views;
using BE;


namespace PL
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainVM mainVM;
        public LoginUC loginUC;
        public GraduateIceCreamUC GraduateIceCream;
        public SearchIceCreamUC SearchIceCream;
        public ShopAreaUC shopAreaUC;
        public ProfileBarUC profileBarUC;
        public HomeUC homeUC;

        public MainWindow()
        {
            InitializeComponent();
            mainVM = new MainVM();
            this.DataContext = mainVM;

        }

        private void ShopArea(object sender, RoutedEventArgs e)
        {
            loginUC = new LoginUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).full_content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(loginUC);
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            homeUC = new HomeUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).full_content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(homeUC);

        }

        private void graduate_btn_Click(object sender, RoutedEventArgs e)
        {
            GraduateIceCream = new GraduateIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(GraduateIceCream);

        }

        private void shopAreaBtnBis_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop();
            shopAreaUC = new ShopAreaUC(shop.Id);
            profileBarUC = new ProfileBarUC(shop);
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Add(profileBarUC);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

            SearchIceCream = new SearchIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(SearchIceCream);
        }
    }
}
