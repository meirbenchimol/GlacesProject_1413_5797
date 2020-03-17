using System;
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
            this.shopUC = registerShopUC;



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

        private RegisterShopUC shopUC;

       
    }
}
