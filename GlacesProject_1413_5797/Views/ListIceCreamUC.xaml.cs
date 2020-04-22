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
using BL;



namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour ListIceCream.xaml
    /// </summary>
    public partial class ListIceCreamUC : UserControl
    {

        public Bl bl { get; set; }
       
        public ListIceCreamUC(IEnumerable<IceCream> iceCreams)
        {
            bl = new Bl();
            InitializeComponent();
            PersonDetails.ItemsSource = iceCreams;


        }


        private void AvoidDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void OnSelectedItemChanged(object sender, SelectionChangedEventArgs e)
        {
            IceCream ic = (IceCream)PersonDetails.SelectedItem as IceCream;
            string name = ic.Id;
            MessageBox.Show(name,"Excellent!!",MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
