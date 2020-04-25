using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BE;
using BL;
using PL.Views;
using PL.Models;

namespace PL.ViewModel
{
    public class IceCreamShopVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IceCreamShopUC IceCreamShopUC { get; set; }

        private IceCreamShopModel CurrentModel { get; set; }

        public  IceCreamShopVM(IceCreamShopUC iceCreamShopUC)
        {
            this.IceCreamShopUC = iceCreamShopUC;
            CurrentModel = new IceCreamShopModel();
            CurrentModel.iceCream = iceCreamShopUC.iceCream;
            CurrentModel.shop = iceCreamShopUC.shop;
        }

        public string ShopName
        {
            get { return CurrentModel.shop.Id; }

        }



        public string ShopAdress
        {
            get { return CurrentModel.shop.Adress; }
        }


        public string ShopPhone
        {
            get { return CurrentModel.shop.Phone; }


           

        }


        public string ShopWebSite
        {
            get { return CurrentModel.shop.WebSiteLink; }



        }


        public string FaceBook
        {
            get { return CurrentModel.shop.FaceBookLink; }

        }




        public string IceCreamID
        {


            get { return  CurrentModel.iceCream.Id; }

        }

        public string IceCreamEnergy
        {
            get { return CurrentModel.iceCream.Energy.ToString(); }


        }


        public string IceCreamProteins
        {
            get { return CurrentModel.iceCream.Proteins.ToString(); }


        }



        public string IceCreamCalories
        {
            get { return CurrentModel.iceCream.Calories.ToString(); }

        }


        public string IceCreamGrade
        {
            get
            {


                string[] grade = CurrentModel.iceCream.Marks.Split(',').ToArray();


                return "Grade: " + grade[0];

            }
        }




    }

}
