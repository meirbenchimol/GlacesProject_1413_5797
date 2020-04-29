using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PL.Models;
using PL.Views;
using PL.Commands;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;

namespace PL.ViewModel
{
    public class RegisterShopVM : INotifyPropertyChanged
    {
        public Command ImageCommand { get; set; }

        public RegisterShopVM( RegisterShopUC registerShopUC)
        {
            CurrentModel = new RegisterShopModel();
            this.ShopUC = registerShopUC;
            this.MyCommand = new SpecialCommand();
            this.ImageCommand = new Command();
            MyCommand.callComplete +=  RegisterShop;
            ImageCommand.callComplete += OpenFileCommand;

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

        public SpecialCommand MyCommand { get; set; }

        private string Image { get; set; }

        private void OpenFileCommand()
        {


            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image = open.FileName;
            }
          //  this.MyImage = Image;
            //  GraduationUC.addimage.ImageSource = Image;
        }

        #region  functions


        public void UpdateShop()
        {




        }

        public void RegisterShop(string obj)
        {

            bool found = CurrentModel.MyBl.CheckShopExist(CurrentModel.MyShop.Id);
            if(found)
                System.Windows.MessageBox.Show("Warning !! A Shop  with same ID already exists !!", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            else
            {
                if(Image != null)
                    CurrentModel.MyShop.images.Add(Image);
                CurrentModel.MyShop.UpdateData();
                CurrentModel.AddShop();
                System.Windows.MessageBox.Show("Great !! You're now a Shop of our company  !!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
           

        }

          #endregion

    }
}
