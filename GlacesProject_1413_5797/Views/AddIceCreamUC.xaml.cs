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
using BE;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour AddIceCream.xaml
    /// </summary>
    public partial class AddIceCreamUC : UserControl
    {
        public ShopAreaUC shopAreaUC;
        public string ShopId;
        public IceCream currentIceCream;
        public AddIceCreamVM AddIceCreamVM { get; set; }

        public AddIceCreamUC(string shopId)
        {
            InitializeComponent();
            ShopId = shopId;
            AddIceCreamVM = new AddIceCreamVM(this);
            this.DataContext = AddIceCreamVM;
            addIceCreamBtn.Visibility = Visibility.Visible;
            UpdateIceCreamBtn.Visibility = Visibility.Collapsed;
        }

        public AddIceCreamUC(string shopId , IceCream iceCream)
        {
            InitializeComponent();
            ShopId = shopId;
            currentIceCream = iceCream;
            AddIceCreamVM = new AddIceCreamVM(this  ,iceCream);
            this.DataContext = AddIceCreamVM;
            ImageButton.Content = "Change the image";
            addIceCreamBtn.Visibility = Visibility.Collapsed;
            UpdateIceCreamBtn.Visibility = Visibility.Visible;
        }

        private void CalculeBtn_Click(object sender, RoutedEventArgs e)
        {
            attribut_grid.Visibility = Visibility.Visible;

            getApiFoodDetails("Ice creams, " + this.Taste);
           // MessageBox.Show(this.AddIceCreamVM.CurrentModel.getApiFoodDetails("Ice creams, "+ this.Taste),
               // "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Bnt_return_Click(object sender, RoutedEventArgs e)
        {
            
            shopAreaUC = new ShopAreaUC(ShopId);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);

        }


        public void getApiFoodDetails(string foodName)
        {

            string AsckFoodKey = @"https://api.nal.usda.gov/ndb/search/?format=JSON&q=" + foodName + "&sort=n&max=25&offset=0&api_key=" + "iFjZG9JHsryEhpdo9qfprQVFg2HM3faohPZ00O4Y";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AsckFoodKey);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd(); //Json format

            JObject responsJ = JObject.Parse(responsereader);

            //we take just first answer,TODO:auto complete
            IEnumerable<JToken> responsJ2 = responsJ["list"]["item"];//.Where(temp => temp["name"].ToString().Contains("BREAKFAST")).Select(temp => temp);

            string keyFood = responsJ2.First<JToken>()["ndbno"].ToString(); //the key-num of corunty branded
            string AsckFoodComponents = @" https://api.nal.usda.gov/ndb/V2/reports?ndbno=" + keyFood + "&type=b&format=JSON&api_key=" + "iFjZG9JHsryEhpdo9qfprQVFg2HM3faohPZ00O4Y";
            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(AsckFoodComponents);
            WebResponse response2 = request2.GetResponse();
            Stream dataStream2 = response2.GetResponseStream();
            StreamReader sreader2 = new StreamReader(dataStream2);
            string responsereader2 = sreader2.ReadToEnd();

            //value per 100g
            JObject responsJFoodDetails = JObject.Parse(responsereader2);

            double energy = getNutrientsValue(responsJFoodDetails, "Energy");
            // carbs = getNutrientsValue(responsJFoodDetails, "Carbohydrate, by difference");
            double proteins = getNutrientsValue(responsJFoodDetails, "Protein");
            double fats = getNutrientsValue(responsJFoodDetails, "Total lipid (fat)");

            // string name = responsJ2.First<JToken>()["name"].ToString();


            this.Fats.Text = fats.ToString();
            this.Energy.Text = energy.ToString();
            this.Proteins.Text = proteins.ToString();
            this.Proteins.IsEnabled = false;
            this.Energy.IsEnabled = false;
            this.Fats.IsEnabled = false;
        }



        private double getNutrientsValue(JObject responsJFoodDetails, string wantedNutrient)
        {

            IEnumerable<JToken> responsJk = responsJFoodDetails["foods"][0]["food"]["nutrients"].Where(temp => temp["name"].ToString().Contains(wantedNutrient)).Select(temp => temp["value"]).First<JToken>();
            //responsJk = responsJk.Where(temp => temp["eunit"].ToString().Contains("g")).Select(temp => temp["value"]).First<JToken>();//=מידה measure
            string value = responsJk.ToString();
            string s = value.Replace(".", ",");
            return double.Parse(s);

        }

    }
}
