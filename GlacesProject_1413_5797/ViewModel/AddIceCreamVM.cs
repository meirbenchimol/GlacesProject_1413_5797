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

namespace PL.ViewModel
{
    public class AddIceCreamVM  : INotifyPropertyChanged
    {

        public AddIceCreamModel CurrentModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private AddIceCreamUC addIceCreamUC;
        public SpecialCommand MyCommand { get; set; }

        public AddIceCreamVM(AddIceCreamUC addIceCreamUC)
        {
            CurrentModel = new AddIceCreamModel();
            MyCommand = new SpecialCommand();
            this.addIceCreamUC = addIceCreamUC;
            MyCommand.callComplete += MyCommand_AddIceCream;
        }




        public string Id
        {
            get { return CurrentModel.MyIC.Id; }
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
                    string s="";
                for (int i = 0; i < CurrentModel.MyIC.Taste.ToList().Count; i++)
                    s+= CurrentModel.MyIC.Taste[i].ToString() + "'";

                return s;
                            
                 }

            set
            {
                string Taste = value;
                String[] taste = Taste.Split(',');
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Taste"));
                CurrentModel.MyIC.Taste = taste;

            }
        }

        public string Description
        {
            get { return CurrentModel.MyIC.Description; }
            set
            {
                CurrentModel.MyIC.Description = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }




        public void MyCommand_AddIceCream(string obj)
        {

            CurrentModel.AddIceCream();

        }

    }
}
