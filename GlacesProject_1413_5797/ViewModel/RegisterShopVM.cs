﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PL.Models;
using PL.Views;

namespace PL.ViewModel
{
    public class RegisterShopVM : INotifyPropertyChanged
    {


        public RegisterShopVM( RegisterShopUC registerShopUC)
        {
            CurrentModel = new RegisterShopModel();
            this.ShopUC = registerShopUC;

        }

        public RegisterShopModel CurrentModel { get; set; }

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


        private RegisterShopUC ShopUC;



      

       
    }
}
