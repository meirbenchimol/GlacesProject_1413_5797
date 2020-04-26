using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PL.Models;
using PL.Views;
using PL.Commands;
using BE;
using System.Windows;

namespace PL.ViewModel
{
    public class AddIceCreamVM  : INotifyPropertyChanged
    {


        public AddIceCreamVM(AddIceCreamUC addIceCreamUC)
        {
            CurrentModel = new AddIceCreamModel(addIceCreamUC.ShopId);
            this.addIceCreamUC = addIceCreamUC;
            this.MyCommand = new SpecialCommand();
            MyCommand.callComplete += AddIceCream;
        }

        public AddIceCreamVM(AddIceCreamUC addIceCreamUC, IceCream iceCream)
        {
            CurrentModel = new AddIceCreamModel(addIceCreamUC.ShopId , iceCream);
            this.addIceCreamUC = addIceCreamUC;
            this.MyCommand = new SpecialCommand();
            MyCommand.callComplete += UpdateCream;
        }

        public AddIceCreamModel CurrentModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private AddIceCreamUC addIceCreamUC;
        public SpecialCommand MyCommand { get; set; }


        public string Id
        {
            get { return CurrentModel.oldIceCream.Id; }
            set
            {
                CurrentModel.MyIC.Id = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }
        

        public string  Taste
        {
            get {
                    string s= CurrentModel.oldIceCream.Taste;
                     return s;
                            
                 }

            set
            {
                CurrentModel.MyIC.Taste = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Taste"));
               

            }
        }

        public string Description
        {
            get { return CurrentModel.oldIceCream.Description; }
            set
            {
                CurrentModel.MyIC.Description = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }


        #region  functions


        public void AddIceCream(string obj)
        {

            bool found = CurrentModel.MyBl.CheckIceCream(CurrentModel.MyIC.Id, CurrentModel.MyIC.ShopId);
            if (found)
                MessageBox.Show("Warning !!  IceCream  with same ID already exists !!", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            else
            {
                CurrentModel.AddIceCream();
                MessageBox.Show("Great !! You have add Ice Cream  !!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        public void UpdateCream(string obj)
        {
            CurrentModel.UpdateIceCream();

        }



        #endregion

    }
}
