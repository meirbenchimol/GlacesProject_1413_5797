using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.Models;
using PL.Views;
using System.ComponentModel;
using System.Windows;

namespace PL.ViewModel
{
    public class ProfileBarIceCreamVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public ProfileBarIceCreamModel ProfileBarIceCreamModel { get; set; }
        private ProfileBarIceCreamUC ProfileBarIceCreamUC;



        public ProfileBarIceCreamVM(ProfileBarIceCreamUC profileBarIceCreamUC)
        {
            ProfileBarIceCreamModel = new ProfileBarIceCreamModel();
            ProfileBarIceCreamModel.IceCream = profileBarIceCreamUC.iceCream;
            this.ProfileBarIceCreamUC = profileBarIceCreamUC;
            

        }


        public string ID
        {


            get { return  ProfileBarIceCreamUC.iceCream.Id; }

        }




        public string ShopID
        {
            get { return ProfileBarIceCreamUC.iceCream.ShopId; }

        }

        public string Image
        {
            get
            {  return ProfileBarIceCreamUC.iceCream.Image; }
        }



        public string Taste
        {


            get { return ProfileBarIceCreamUC.iceCream.Taste; }

        }

        public string Presentation
        {


            get { return ProfileBarIceCreamUC.iceCream.Presentation; }

        }


        public string Energy
        {
            get { return ProfileBarIceCreamUC.iceCream.Energy.ToString(); }


        }


        public string Proteins
        {
            get { return ProfileBarIceCreamUC.iceCream.Proteins.ToString(); }


        }



        public string Calories
        {
            get { return ProfileBarIceCreamUC.iceCream.Calories.ToString(); }

        }


        public string Grade
        {
            get
            {


                string[] grade = ProfileBarIceCreamUC.iceCream.Marks.Split(',').ToArray();


                return  grade[0];

            }
        }



        public string Comments
        {

            set
            {

                ProfileBarIceCreamUC.iceCream.comments.Add(value);
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Comments"));

            }


        }

    }












}
