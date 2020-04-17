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
using BE;

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for ProfileBarUC.xaml
    /// </summary>
    public partial class ProfileBarUC : UserControl
    {
        public Shop Shop { get; set; }
        public ProfileBarVM ProfileBarVM { get; set; }


        public ProfileBarUC(Shop shop)
        {
            InitializeComponent();
            Shop = shop;
            ProfileBarVM = new ProfileBarVM(this);
            this.DataContext = ProfileBarVM;
        }

    }
}
