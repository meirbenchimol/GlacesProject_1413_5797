using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace BE
{
    public class Shop
    {
        [Key , Column(Order=0)]
        public string Id { get; set; }
       
        public string Password { get; set; }


        public string Adress { get; set; }

        public string Phone { get; set; }


        public String FaceBookLink { get; set; }


        public String WebSiteLink { get; set; }

        private List<String> images = new List<string>();

        public List<String> Images
        {
            get { return images;}
        }

        private List<IceCream> products= new List<IceCream>();

        public List<IceCream> Products
        {
            get { return products; }
        }

    }
}
