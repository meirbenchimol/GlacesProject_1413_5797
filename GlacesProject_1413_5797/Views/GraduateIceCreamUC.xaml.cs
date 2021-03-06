﻿

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
        public GraduationUC graduationUC { get; set; }
        public ProfileBarIceCreamUC profileBarIceCreamUC { get; set; }
        public GraduateIceCreamUC()
        {

            InitializeComponent();
            MyBl = new Bl();

           
            ShopComboBox.ItemsSource = MyBl.GetAllShop();
            ShopComboBox.DisplayMemberPath = "Id";
            ShopComboBox.SelectedValuePath = "Id";

        }



        private void Graduate(object sender, RoutedEventArgs e)
        {
            IceCream Ic = IceCreamComboBox.SelectedItem as IceCream;
            Ic.UpdateLists();
            graduationUC = new GraduationUC(Ic);
            profileBarIceCreamUC = new ProfileBarIceCreamUC(Ic);
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(graduationUC);
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Add(profileBarIceCreamUC);



        }

        private void Shop_Selected(object sender, SelectionChangedEventArgs e)
        {
            IceCreamComboBox.IsEnabled = true;
            Shop shop = ShopComboBox.SelectedItem as Shop;
            
            IceCreamComboBox.ItemsSource = MyBl.GetIceCreamFromShop(shop.Id);
            IceCreamComboBox.DisplayMemberPath = "Presentation";
            IceCreamComboBox.SelectedValuePath = "Presentation";
            
        }
    }
}
