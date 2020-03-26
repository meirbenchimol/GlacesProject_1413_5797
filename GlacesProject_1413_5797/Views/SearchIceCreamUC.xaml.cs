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



        public BE.Taste ConvertStringToTaste(string taste)
        {
            switch(taste)
            { 
                case "Chocolate": return BE.Taste.Chocolate;
                                

                 case "Vanilla": return BE.Taste.Vanilla;

                 case "Strawbery": return BE.Taste.Strawberry;
                 
                 case "Pistachio": return BE.Taste.Pistachio;

                 default :
                            return BE.Taste.Chocolate;
            }
                




        }

        private void Search(object sender, RoutedEventArgs e)
        {

            BE.Taste taste = ConvertStringToTaste(Taste.Text.ToString());
            IEnumerable<BE.IceCream> IceCreams =  MyBl.FindListIceCream(taste, Energy.Value, Calories.Value, Proteins.Value, Minimum.Value, Maximum.Value);


        }
    }
}
