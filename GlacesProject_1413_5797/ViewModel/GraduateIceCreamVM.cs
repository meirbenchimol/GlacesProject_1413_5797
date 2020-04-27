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
using PL.Commands;
using System.Windows.Forms;
using System.Windows.Controls;

namespace PL.ViewModel
{
    public class GraduateIceCreamVM : INotifyPropertyChanged
    {

        public GraduateICModel GraduateICModel { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private GraduationUC GraduationUC;
        private ProfileBarIceCreamUC ProfileBarIceCreamUC;
        public SpecialCommand MyCommand { get; set;  }

        public SpecialCommand ImageCommand { get; set; }

        public HomeUC homeUC { get; set; }

        private string Image { get; set; }
        

        public GraduateIceCreamVM(GraduationUC graduationUC)
        {
            GraduateICModel = new GraduateICModel();
            GraduateICModel.IceCream = graduationUC.SelectedIceCream;
            this.GraduationUC = graduationUC;
            this.MyCommand = new SpecialCommand();
            this.ImageCommand = new SpecialCommand();
            MyCommand.callComplete += MyCommand_UpdateIceCream;
            ImageCommand.callComplete += OpenFileCommand;

        }
        public GraduateIceCreamVM(ProfileBarIceCreamUC profileBarIceCreamUC)
        {
            GraduateICModel = new GraduateICModel();
            GraduateICModel.IceCream = profileBarIceCreamUC.iceCream;
            this.ProfileBarIceCreamUC = profileBarIceCreamUC;
            

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


     







        private void MyCommand_UpdateIceCream(string parameter)
        {

            GraduateICModel.IceCream.marks.Add((Int32)(GraduationUC.Grades.Value));

            GraduateICModel.IceCream.images.Add(Image.ToString());
            GraduateICModel.IceCream.marks[0] = (Int32)GraduateICModel.IceCream.marks.Skip(1).Take(GraduateICModel.IceCream.marks.Count - 1).Average();
            System.Windows.MessageBox.Show("Thanks for your appreciation !! See you soon !!", "Thanks", MessageBoxButton.OK, MessageBoxImage.Exclamation);
              homeUC = new HomeUC();
              ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Clear();
              ((MainWindow)System.Windows.Application.Current.MainWindow).content_grid.Children.Clear();
              ((MainWindow)System.Windows.Application.Current.MainWindow).profile_grid.Children.Clear();
              ((MainWindow)System.Windows.Application.Current.MainWindow).inner_grid.Children.Add(homeUC);
         

            GraduateICModel.IceCream.UpdateData();
            GraduateICModel.UpdateIceCream(GraduationUC.SelectedIceCream, GraduateICModel.IceCream);
          }

        private void OpenFileCommand(string parameter)
        {


            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                 Image = open.FileName;
            }

          //  GraduationUC.addimage.ImageSource = Image;
        }



        }

}
