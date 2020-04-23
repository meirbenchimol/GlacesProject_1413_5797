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

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour SearchIceCream.xaml
    /// </summary>
    public partial class SearchIceCreamUC : UserControl
    {
        public Bl MyBl { get; set; }
        public ListIceCreamUC  listIceCreamUC { get; set; }

        public SearchIceCreamUC()
        {
            InitializeComponent();
            MyBl = new Bl();
            this.TasteComboBox.ItemsSource = taste;
            
            

        }


        List<string> taste = new List<string> { "Pistachio", "Fraise", "Chocolate", "Vanille" };

        

        private void Search(object sender, RoutedEventArgs e)
        {

            string Taste = TasteComboBox.SelectedItem.ToString();


            
            IEnumerable<BE.IceCream> IceCreams =  MyBl.FindListIceCream(Taste, Energy.Value, Calories.Value, Proteins.Value, Median.Value);
           // IEnumerable<BE.IceCream> IceCreams = MyBl.GetAllIceCream();
            listIceCreamUC = new ListIceCreamUC(IceCreams);
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(listIceCreamUC);

        }
    }
}
