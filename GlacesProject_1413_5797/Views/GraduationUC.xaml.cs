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
using PL.ViewModel;

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour GraduationUC.xaml
    /// </summary>
    public partial class GraduationUC : UserControl
    {

        public GraduateIceCreamVM graduateIceCreamVM { get; set; }

        public IceCream SelectedIceCream { get; set; }

        public GraduationUC(IceCream iceCream)
        {
            InitializeComponent();
            SelectedIceCream = iceCream;
          //  MessageBox.Show(SelectedIceCream.Marks.ToCharArray().ElementAt(0).ToString(), "Thanks", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            graduateIceCreamVM = new GraduateIceCreamVM(this);
            this.DataContext = graduateIceCreamVM;
   
        }

       
    }
}
