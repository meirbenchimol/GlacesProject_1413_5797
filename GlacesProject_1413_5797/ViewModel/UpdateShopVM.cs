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
using System.Windows.Forms;

namespace PL.ViewModel
{
    public class UpdateShopVM: INotifyPropertyChanged
    {


        public UpdateShopVM(UpdateShopUC updateShopUC)
        {
            CurrentModel = new UpdateShopModel();
            CurrentModel.MyShop = updateShopUC.shop;
            this.UpdateShopUC = updateShopUC;
            updateShopUC.Password.Password = CurrentModel.MyShop.Password;
            updateShopUC.ConfirmPassword.Password = CurrentModel.MyShop.Password;
            this.MyCommand = new SpecialCommand();
            MyCommand.callComplete += UpdateShop;
            ImageCommand = new Command();
            ImageCommand.callComplete += OpenFileCommand;

        }

        private string image { get; set; }

        public UpdateShopModel CurrentModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command ImageCommand { get; set; }

        public string Image
        {
            get { return CurrentModel.MyShop.images[0]; }
        }

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

            CurrentModel.MyShop.images.RemoveAt(0);
            CurrentModel.MyShop.images.Add(image);
            CurrentModel.MyShop.UpdateData();
            CurrentModel.UpdateShop(UpdateShopUC.shop, CurrentModel.MyShop);

            //private ShopAreaUC shopAreaUC = new ShopAreaUC(UpdateShopUC.shop.Id);
            //profileBarUC = new ProfileBarUC(shop);
           


        }


        private void OpenFileCommand()
        {


            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                image = open.FileName;
            }
            //this.MyImage = Image;
            //  GraduationUC.addimage.ImageSource = Image;
        }
        #endregion
    }



}
