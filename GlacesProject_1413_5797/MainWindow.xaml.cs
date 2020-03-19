﻿using System;
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


namespace GlacesProject_1413_5797
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainVM mainVM;
        public LoginUC loginUC;
        
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
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(loginUC);
        }
    }
}
