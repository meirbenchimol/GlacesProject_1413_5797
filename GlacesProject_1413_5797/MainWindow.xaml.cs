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
using PL.Views;
using BE;
using GoogleMaps.LocationServices;
using GoogleMapsApi;
using System.Net;
using System.Data;
using System.IO;

namespace PL
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainVM mainVM;
        public LoginUC loginUC;
        public GraduateIceCreamUC GraduateIceCream;
        public SearchIceCreamUC SearchIceCream;
        public ShopAreaUC shopAreaUC;
        public ProfileBarUC profileBarUC;
        public HomeUC homeUC;

        public MainWindow()
        {
            InitializeComponent();
            mainVM = new MainVM();
            this.DataContext = mainVM;

        }

        private void ShopArea(object sender, RoutedEventArgs e)
        {
            loginUC = new LoginUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).full_content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(loginUC);
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
          //  essai();
            homeUC = new HomeUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).full_content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(homeUC);

        }

        public  void  essai()
        {
            string s = "";
            string url = "http://maps.google.com/maps/api/geocode/xml?address=" +  "8 Place de Bordeaux , Strasbourg" + "&sensor=false";
            WebRequest request = WebRequest.Create(url);

            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    DataSet dsResult = new DataSet();
                    dsResult.ReadXml(reader);
                    DataTable dtCoordinates = new DataTable();
                    dtCoordinates.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
                    new DataColumn("Address", typeof(string)),
                    new DataColumn("Latitude",typeof(string)),
                    new DataColumn("Longitude",typeof(string)) });
                    foreach (DataRow row in dsResult.Tables["result"].Rows)
                    {
                        string geometry_id = dsResult.Tables["geometry"].Select("result_id = " + row["result_id"].ToString())[0]["geometry_id"].ToString();
                        DataRow location = dsResult.Tables["location"].Select("geometry_id = " + geometry_id)[0];
                        dtCoordinates.Rows.Add(row["result_id"], row["formatted_address"], location["lat"], location["lng"]);
                    }

                    s = dtCoordinates.Columns[2].ToString();
                    //s = dtCoordinates.Rows[2].ToString();
                }
                // return dtCoordinates["Latitude"];

                System.Windows.MessageBox.Show(s, "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            // Save lat/long values to DB...
        }
        private void graduate_btn_Click(object sender, RoutedEventArgs e)
        {
            GraduateIceCream = new GraduateIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(GraduateIceCream);

        }

        private void shopAreaBtnBis_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop();
            shopAreaUC = new ShopAreaUC(shop.Id);
            profileBarUC = new ProfileBarUC(shop);
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Add(profileBarUC);
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(shopAreaUC);
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

            SearchIceCream = new SearchIceCreamUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).shopAreaGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Add(SearchIceCream);
        }
    }
}
