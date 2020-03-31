using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
//using System.Data.Entity;
using System.Drawing;
using BE;
using Microsoft.EntityFrameworkCore;

namespace BE

   
{
    

    public class IceCream
    {
        [Key, Column(Order = 0)]
        public string Id { get; set; }
       [Key,ForeignKey("Shop"), Column(Order =1)]
        public string ShopId { get; set; }

        public string[] Taste { get; set; }

    
    //comment test git meir

        static string  id="";

        public string Description { get; set; }


        public string Presentation
        {
            get {
                string s = Id;
                for ( int i = 0;i< Taste.ToList().Count;i++)
                {
                    s += Taste[i].ToString();
                }
                return s;
               }
        }

        private List<string> images = new List<string>();

        public string [] Images
        {
            get;set;
        }


        public string Image
        {
            get { return images[0]; }

            set { Image = images[0]; }
        }


        public double? Energy { get; set; }

        public double?  Proteins { get; set; }

        public double? Calories { get; set; }

        public int[] marks { get; set; }


      
        public string[] Comments { get; set; }


       




        public IceCream()
        {

            Id = id;
            id += "a";
            ShopId = "shop";
            Taste[0]="Chocolate";
            images[0]="iceCream_choco.png";
            Comments[0] = "ggg";
            marks[0]= 5;
            Energy = 70;
            Proteins = 80;
            Calories = 85;
            Description = "";
        }

    }
}
