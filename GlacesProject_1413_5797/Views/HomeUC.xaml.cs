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

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for HomeUC.xaml
    /// </summary>
    public partial class HomeUC : UserControl
    {
        public LoginUC loginUC;
        public GraduateIceCreamUC graduateIceCream;
        public SearchIceCreamUC searchIceCreamUC;


        public HomeUC()
        {
            InitializeComponent();
        }

        private void ShopArea(object sender, RoutedEventArgs e)
        {
            loginUC = new LoginUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).homeGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).homeGrid.Children.Add(loginUC);
        }
        private void graduate_btn_Click(object sender, RoutedEventArgs e)
        {
            graduateIceCream = new GraduateIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(graduateIceCream);

        }



        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

            searchIceCreamUC = new SearchIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(searchIceCreamUC);
        }

    }
}
