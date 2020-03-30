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


namespace PL
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainVM mainVM;
        public LoginUC loginUC;
        public GraduateIceCreamUC graduateIceCream;
        
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
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(loginUC);
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
        }

        private void graduate_btn_Click(object sender, RoutedEventArgs e)
        {
            graduateIceCream = new GraduateIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(graduateIceCream);

        }
    }
}
