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


namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour AddIceCream.xaml
    /// </summary>
    public partial class AddIceCreamUC : UserControl
    {
        public AddIceCreamVM AddIceCreamVM { get; set; }

        public AddIceCreamUC()
        {
            InitializeComponent();
            AddIceCreamVM = new AddIceCreamVM(this);
            this.DataContext = AddIceCreamVM;
        }



    }
}
