using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Models;
using PL.Views;
using System.ComponentModel;
using PL.Commands;

namespace PL.ViewModel
{
    public class LoginVM  
    {
        public LoginVM(LoginUC LoginUC)
        {
            CurrentModel = new LoginModel();
            this.LoginUC = LoginUC;
            
        }

        public LoginModel CurrentModel { get; set; }

        

        private LoginUC LoginUC;

        public SpecialCommand specialCommand;




    }
}
