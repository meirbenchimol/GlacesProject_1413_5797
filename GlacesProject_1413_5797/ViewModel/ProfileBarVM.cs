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

namespace PL.ViewModel
{
    public class ProfileBarVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ProfileBarModel CurrentModel { get; set; }
        private ProfileBarUC profileBarUC;



        public ProfileBarVM(ProfileBarUC profileBarUC)
        {
            CurrentModel = new ProfileBarModel(profileBarUC.Shop);
            this.profileBarUC = profileBarUC;

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
    }
}
