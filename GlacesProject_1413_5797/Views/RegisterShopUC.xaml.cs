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
using PL.ViewModel;

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour RegisterShopUC.xaml
    /// </summary>
    public partial class RegisterShopUC : UserControl
    {

        public RegisterShopVM ShopVM { get; set; }
        public RegisterShopUC()
        {
            InitializeComponent();
            ShopVM = new RegisterShopVM(this);
            this.DataContext = ShopVM;
        }


        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void add_profile_img_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
