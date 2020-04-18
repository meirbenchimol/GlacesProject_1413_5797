using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace PL.Models
{
    public class MainModel
    {
        public Shop Current_Shop { get; set; }

        public Bl bl { get; set; }

        public MainModel()
        {
            bl = new Bl();
            Current_Shop = new Shop();
          //  bl.AddShop(Current_Shop);

        }
    }
}
