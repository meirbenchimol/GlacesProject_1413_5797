using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Models;
using PL.Views;
using System.ComponentModel;
using PL.Commands;
using BE;

using System.Windows;

namespace PL.ViewModel
{
    public class LoginVM
    {
        public LoginVM(LoginUC LoginUC)
        {
            CurrentModel = new LoginModel();
            this.LoginUC = LoginUC;
            this.specialCommand = new SpecialCommand();
            specialCommand.callComplete += Login_Command;
        }

        public LoginModel CurrentModel { get; set; }



        private LoginUC LoginUC;

        public SpecialCommand specialCommand { get; set; }


        public void Login_Command(string obj)
        {
            bool found = CurrentModel.findShopByLogin(LoginUC.Id.Text, LoginUC.Password.Password);

            if(found)
                System.Windows.MessageBox.Show("great!", "great", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            else
                System.Windows.MessageBox.Show("error!", "error", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }



    }

    
}
