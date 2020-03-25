using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.Models;
using PL.Views;
using System.ComponentModel;
using PL.Commands;

namespace PL.ViewModel
{
    public class GraduateIceCreamVM : INotifyPropertyChanged
    {

        public GraduateICModel GraduateICModel { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private GraduationUC GraduationUC;
        public SpecialCommand MyCommand;


        public GraduateIceCreamVM(GraduationUC graduationUC)
        {
            GraduateICModel = new GraduateICModel();
            GraduateICModel.IceCream = graduationUC.SelectedIceCream;
            this.GraduationUC = graduationUC;
            this.MyCommand = new SpecialCommand();
            MyCommand.callComplete += MyCommand_UpdateIceCream;

        }



        public string ID
        {


            get {   return GraduationUC.SelectedIceCream.Id;  }

        }




        public string ShopID
        {


            get { return GraduationUC.SelectedIceCream.ShopId; }

        }


        public string Presentation
        {


            get { return GraduationUC.SelectedIceCream.Presentation; }

        }


        public string Energy
        {
            get { return GraduationUC.SelectedIceCream.Energy.ToString(); }


        }


        public string Proteins
        {
            get { return GraduationUC.SelectedIceCream.Proteins.ToString(); }


        }



        public string Calories
        {
            get { return GraduationUC.SelectedIceCream.Calories.ToString(); }

        }


        public string Grade
        {
            get { return GraduationUC.SelectedIceCream.marks[0].ToString(); }
        }



        public string Comments
        {

            set { GraduateICModel.IceCream.Comments.Add(value); }


        }



        public string Grades
        {

            set { GraduateICModel.IceCream.marks.Add(value); }


        }


        private void MyCommand_UpdateIceCream(string parameter )
        {


            GraduateICModel.UpdateIceCream(GraduationUC.SelectedIceCream, GraduateICModel.IceCream);
        }



    }

}
