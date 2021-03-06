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
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using Microsoft.Maps;


namespace PL.ViewModel
{
    public class AddIceCreamVM : INotifyPropertyChanged
    {


        public AddIceCreamVM(AddIceCreamUC addIceCreamUC)
        {
            CurrentModel = new AddIceCreamModel(addIceCreamUC.ShopId);
            this.addIceCreamUC = addIceCreamUC;
            this.MyCommand = new SpecialCommand();
            AddCommand = new Command();
            MyCommand.callComplete += AddIceCream;
            AddCommand.callComplete += OpenFileCommand;
        }

        public AddIceCreamVM(AddIceCreamUC addIceCreamUC, IceCream iceCream)
        {


            CurrentModel = new AddIceCreamModel(addIceCreamUC.ShopId, iceCream);
            this.addIceCreamUC = addIceCreamUC;
            this.MyCommand = new SpecialCommand();
            AddCommand = new Command();
            // addIceCreamUC.Taste.TextChanged += ChangeData;
            addIceCreamUC.Fats.Text = iceCream.Calories.ToString();
            addIceCreamUC.Proteins.Text = iceCream.Proteins.ToString();
            addIceCreamUC.Energy.Text = iceCream.Energy.ToString();
            MyCommand.callComplete += UpdateCream;
            AddCommand.callComplete += OpenFileCommand;
        }

        public AddIceCreamModel CurrentModel { get; set; }

        private string Image { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        private AddIceCreamUC addIceCreamUC;
        public SpecialCommand MyCommand { get; set; }

        public Command AddCommand { get; set; }


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

        public string MyImage
        {
            get { return CurrentModel.MyIC.Image; }

            set
            {
                value = Image;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Image"));
            }
        }

        public string Taste
        {
            get
            {
                string s = CurrentModel.oldIceCream.Taste;
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
                System.Windows.MessageBox.Show("Warning !!  IceCream  with same ID already exists !!", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            else
            {

                if (Image != null)
                {

                    CurrentModel.MyIC.images.Add(Image);
                }
                else
                    CurrentModel.MyIC.images.Add("../Image/font_ice_cream.jpg");
                //  CurrentModel.MyIC.images.Add(Image);
                CurrentModel.MyIC.Calories = double.Parse(addIceCreamUC.Fats.Text);
                CurrentModel.MyIC.Proteins = double.Parse(addIceCreamUC.Proteins.Text);
                CurrentModel.MyIC.Energy = double.Parse(addIceCreamUC.Energy.Text);
                CurrentModel.MyIC.UpdateData();
                CurrentModel.AddIceCream();
                System.Windows.MessageBox.Show("Great !! You have add Ice Cream  !!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        public void UpdateCream(string obj)
        {

            if (Image != null)
            {

                if (CurrentModel.MyIC.images.Count != 0)
                {
                    CurrentModel.MyIC.images.RemoveAt(0);
                    CurrentModel.MyIC.images.Insert(0, Image);
                }
              

            }

            CurrentModel.MyIC.Calories = double.Parse(addIceCreamUC.Fats.Text);
            CurrentModel.MyIC.Proteins = double.Parse(addIceCreamUC.Proteins.Text);
            CurrentModel.MyIC.Energy = double.Parse(addIceCreamUC.Energy.Text);
            CurrentModel.MyIC.UpdateData();
            CurrentModel.UpdateIceCream();

        }

        private void OpenFileCommand()
        {


            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image = open.FileName;
            }
            ///  this.MyImage = Image;
            //  GraduationUC.addimage.ImageSource = Image;
        }



        #endregion

    }
}
