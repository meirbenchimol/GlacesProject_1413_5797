using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using System.ComponentModel;
using PL.Models;

namespace PL.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainModel mainModel;
        public MainVM()
        {
            mainModel = new MainModel();
        }

        public void UpdateShop(Shop shop)
        {
            mainModel.Current_Shop = shop; 
        }
    }
}
