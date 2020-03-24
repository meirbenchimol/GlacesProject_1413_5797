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

        public SearchIceCreamUC()
        {
            InitializeComponent();
            MyBl = new Bl();

        }

        private void Search(object sender, RoutedEventArgs e)
        {
            if (Taste.Text.Equals(BE.Taste.Chocolate) || Taste.Text.Equals(BE.Taste.Vanilla)
                       || Taste.Text.Equals(BE.Taste.Pistachio) || Taste.Text.Equals(BE.Taste.Strawberry))
                MyBl.FindListIceCream(Taste.Text.ToString(), Energy.Value, Calories.Value, Proteins.Value, Minimum.Value, Maximum.Value);
        }
    }
}
