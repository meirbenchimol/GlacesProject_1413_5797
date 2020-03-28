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
using PL;

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour LoginUC.xaml
    /// </summary>
    /// 

    public partial class LoginUC : UserControl
    {
        public LoginVM LoginVM;
        public RegisterShopVM registerShopVM;
        public LoginUC()
        {
            InitializeComponent();
            LoginVM = new LoginVM(this);
            this.DataContext = LoginVM;
        }


        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }



        private void Register(object sender, RoutedEventArgs e)
        {
            RegisterShopUC registerShopUC = new RegisterShopUC();
            registerShopVM = new RegisterShopVM(registerShopUC);
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(registerShopUC);

        }

    }
   





}
