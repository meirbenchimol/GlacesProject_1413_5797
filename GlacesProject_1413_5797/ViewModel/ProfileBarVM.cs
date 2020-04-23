using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BE;
using BL;
using PL.Models;
using PL.Views;
using PL.Commands;
using System.Windows;

namespace PL.ViewModel
{
    public class ProfileBarVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ProfileBarModel CurrentModel { get; set; }
        private ProfileBarUC profileBarUC;

        private SpecialCommand MyCommand { get; set; }


        public UpdateShopUC updateShopUC;


        public ProfileBarVM(ProfileBarUC profileBarUC)
        {
            CurrentModel = new ProfileBarModel(profileBarUC.Shop);
            this.profileBarUC = profileBarUC;
            MyCommand = new SpecialCommand();
            MyCommand.callComplete += UpdateShop;
        }



        public string ID
        {
            get { return CurrentModel.shop.Id; }


            set
            {
                value = CurrentModel.shop.Id;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ID"));
            }
        }



        public string Adress
        {
            get { return CurrentModel.shop.Adress; }


            set
            {
                value = CurrentModel.shop.Adress;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Adress"));

            }

        }


        public string Phone
        {
            get { return CurrentModel.shop.Phone; }


            set
            {
                value = CurrentModel.shop.Phone;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Phone"));

            }

        }


        public string WebSite
        {
            get { return CurrentModel.shop.WebSiteLink; }


            set
            {
                value = CurrentModel.shop.WebSiteLink;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WebSite"));

            }

        }


        public string FaceBook
        {
            get { return CurrentModel.shop.FaceBookLink; }


            set
            {
                value = CurrentModel.shop.FaceBookLink;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FaceBook"));

            }

        }



        #region Functions


        public void UpdateShop(string obj)
        {
            MessageBox.Show("Great! You've updated your shop space  !!", "Great", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            updateShopUC = new UpdateShopUC(CurrentModel.shop);
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(updateShopUC);



        }




        #endregion
    }
}
