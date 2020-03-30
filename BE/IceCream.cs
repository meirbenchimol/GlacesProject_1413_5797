using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;
using BE;

namespace BE

   
{
    

    public class IceCream
    {
        [Key, Column(Order = 0)]
        public string Id { get; set; }
        [Key, Column(Order =1)]
        public string ShopId { get; set; }

        public List<string> taste = new List<string>();

        public List<string> Taste
        {
            get { return taste; }
        }
    //comment test git meir

        static string  id;

        public string Description { get; set; }


        public string Presentation
        {
            get {
                string s = Id;
                for ( int i = 0;i<taste.Count;i++)
                {
                    s += taste[i].ToString();
                }
                return s;
               }
        }

        private List<string> images = new List<string>();

        public List<string> Images
        {
            get { return images; }
        }


        public string Image
        {
            get { return Image; }

            set { Image = images[0]; }
        }


        public double? Energy { get; set; }

        public double?  Proteins { get; set; }

        public double? Calories { get; set; }

        public ArrayList marks = new ArrayList();

        private List<string> comments = new List<string>();


        public List<string> Comments
        {
            get { return comments; }

            set { comments = value; }
        }




        public IceCream()
        {

            Id = id;
            id += "a";
            ShopId = "shop";
            taste[0] += "Chocolate";



        }

    }
}
