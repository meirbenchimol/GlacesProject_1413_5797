using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Models;
using PL.Views;
using PL.Commands;
using BE;
using System.ComponentModel;
using System.Windows;

namespace PL.ViewModel
{
    public class UpdateShopVM: INotifyPropertyChanged
    {


        public UpdateShopVM(UpdateShopUC updateShopUC)
        {
            CurrentModel = new UpdateShopModel();
            CurrentModel.MyShop = updateShopUC.shop;
            this.UpdateShopUC = updateShopUC;
            this.MyCommand = new SpecialCommand();
            MyCommand.callComplete += UpdateShop;

        }

        public UpdateShopModel CurrentModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public string Id
        {
            get { return CurrentModel.MyShop.Id; }
            set
            {
                CurrentModel.MyShop.Id = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }
        public string Password
        {
            private get { return CurrentModel.MyShop.Password; }
            set
            {
                CurrentModel.MyShop.Password = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public string Adress
        {

            private get { return CurrentModel.MyShop.Adress; }
            set
            {
                CurrentModel.MyShop.Adress = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Adress"));
            }
        }

        public string Phone
        {

            private get { return CurrentModel.MyShop.Phone; }
            set
            {
                CurrentModel.MyShop.Phone = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Phone"));
            }
        }


        public string FaceBook
        {

            private get { return CurrentModel.MyShop.FaceBookLink; }
            set
            {
                CurrentModel.MyShop.FaceBookLink = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FaceBookLink"));
            }
        }


        public string WebSite
        {
            private get { return CurrentModel.MyShop.WebSiteLink; }
            set
            {
                CurrentModel.MyShop.WebSiteLink = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WebSiteLink"));
            }
        }


        private UpdateShopUC UpdateShopUC;

        public SpecialCommand MyCommand { get; set; }



        #region  functions


        public void UpdateShop(string parameter)
        {

            CurrentModel.MyBl.UpdateShop(UpdateShopUC.shop, CurrentModel.MyShop);
            MessageBox.Show("Great! You've updated your shop space  !!", "Great", MessageBoxButton.OK, MessageBoxImage.Exclamation);


        }

        #endregion
    }



}
