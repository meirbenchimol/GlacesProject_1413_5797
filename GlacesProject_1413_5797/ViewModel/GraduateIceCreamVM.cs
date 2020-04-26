﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.Models;
using PL.Views;
using System.ComponentModel;
using System.Windows;
using PL.Commands;

namespace PL.ViewModel
{
    public class GraduateIceCreamVM : INotifyPropertyChanged
    {

        public GraduateICModel GraduateICModel { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private GraduationUC GraduationUC;
        public SpecialCommand MyCommand { get; set;  }

        public HomeUC homeUC { get; set; }


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


            get { return "ID: " + GraduationUC.SelectedIceCream.Id;  }

        }




        public string ShopID
        {
            get { return "Shop: " +  GraduationUC.SelectedIceCream.ShopId; }

        }


        public string Presentation
        {


            get { return  GraduationUC.SelectedIceCream.Presentation; }

        }


        public string Energy
        {
            get { return "Energy: " + GraduationUC.SelectedIceCream.Energy.ToString(); }


        }


        public string Proteins
        {
            get { return "Proteins: " + GraduationUC.SelectedIceCream.Proteins.ToString(); }


        }



        public string Calories
        {
            get { return "Calories: " +  GraduationUC.SelectedIceCream.Calories.ToString(); }

        }


        public string Grade
        {
            get
            {


                string[] grade = GraduationUC.SelectedIceCream.Marks.Split(',').ToArray();


                return "Grade: " + grade[0];

            }
        }



        public string Comments
        {

            set {
               
                GraduateICModel.IceCream.comments.Add(value);
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Comments"));
                
            }


        }



      /*  public string Grades
        {

            set {

              

              
                    
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Grades"));


            }


        }*/


        private void MyCommand_UpdateIceCream(string parameter)
        {

            GraduateICModel.IceCream.marks.Add((Int32)(GraduationUC.Grades.Value));


            GraduateICModel.IceCream.marks[0] = (Int32)GraduateICModel.IceCream.marks.Skip(1).Take(GraduateICModel.IceCream.marks.Count - 1).Average();
            MessageBox.Show("Thanks for your appreciation !! See you soon !!", "Thanks", MessageBoxButton.OK, MessageBoxImage.Exclamation);
              homeUC = new HomeUC();
              ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
              ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
              ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
              ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(homeUC);
         

            GraduateICModel.IceCream.UpdateData();
            GraduateICModel.UpdateIceCream(GraduationUC.SelectedIceCream, GraduateICModel.IceCream);
          }



        }

}
