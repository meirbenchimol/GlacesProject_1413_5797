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
using Microsoft.Win32;



namespace PL.Views

{
    /// <summary>
    /// Logique d'interaction pour UpdateShop.xaml
    /// </summary>
    public partial class UpdateShopUC : UserControl
    {

        public Shop shop { get; set; }

        public UpdateShopVM updateShopVM { get; set; }

        public UpdateShopUC(Shop shop )
        {

            
           
            InitializeComponent();
            this.shop = shop;
            this.updateShopVM = new UpdateShopVM(this);
            this.DataContext = updateShopVM;

        }



        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void add_profile_img_btn_Click(object sender, RoutedEventArgs e)
        {
            String url = "";
            Microsoft.Win32.OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *jpeg; *png;";


        }



        private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (((PasswordBox)sender).Password != this.Password.Password)
            {
                Password.Background = Brushes.Red;
                ConfirmPassword.Background = Brushes.Red;
                //throw new Exception("Warning !!! You must enter the same password !!");
            }
            else
            {
                Password.Background = Brushes.WhiteSmoke;
                ConfirmPassword.Background = Brushes.WhiteSmoke;
            }

        }
    }
}
