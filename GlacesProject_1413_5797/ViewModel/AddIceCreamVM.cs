﻿using System;
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
                for (int i = 0; i < CurrentModel.MyIC.taste.Count; i++)
                    s+= CurrentModel.MyIC.taste[i].ToString() + "'";

                return s;
                            
                 }

            set
            {
                string Taste = value;
                String[] taste = Taste.Split(',');
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Taste"));
                int j = 0;
                for (int i = 0; i < Taste.Count(); i++)
                {

                    if (Taste[i].Equals(BE.Taste.Chocolate) || Taste[i].Equals(BE.Taste.Vanilla)
                        || Taste[i].Equals(BE.Taste.Pistachio) || Taste[i].Equals(BE.Taste.Strawberry))
                        CurrentModel.MyIC.taste[j++] = (BE.Taste)Taste[i];
                }
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