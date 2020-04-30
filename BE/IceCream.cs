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
        [Key, ForeignKey("Shop"), Column(Order = 1)]
        public string ShopId { get; set; }

        public string Taste
        {
            get;
            set;
           
        }

        public List<string> taste = new List<string>();

        public string Description { get; set; }

        public string Presentation
        {
            get {

                string s = Id + " " + Taste ;
              
                return s;
            }
        }

        public string Images 

        {
            get;set;   
        }


        public List<string> images = new List<string>();

        public string Image
        {
            get;
            set;
        }
        


        public double? Energy { get; set; }

        public double? Proteins { get; set; }

        public double? Calories { get; set; }

        public string  Marks

        {
            get;

            set;
          

        }

       // public double MedianGrade { get; set;  }



        public List<int> marks = new List<int>();



        public string Comments

        {

            get;
            set;
           

}
    


        public List<string> comments = new List<string>();


       
        /// <summary>
        /// Update the elements of our database
        /// </summary>
       public void UpdateData()
        {
            Marks = "";
            Marks += marks.ElementAt(0).ToString();
            for (int i = 1; i < marks.Count; i++)
            {
                Marks += "," + marks.ElementAt(i).ToString(); ;
            }

            //MedianGrade = double.Parse(marks.ElementAt(0).ToString());

            Comments = "";
            comments.Add("");
            if (comments != null)
            {
                Comments += comments.ElementAt(0).ToString();
                for (int i = 1; i < comments.Count; i++)
                {
                    Comments += ";" + comments.ElementAt(i).ToString(); ;
                }

            }
           

            Images = "";
            if (images.ElementAt(0) != null) {
                Images += images.ElementAt(0).ToString();

            }
            for (int i = 1; i < images.Count; i++)
            {
                Images += "," + images.ElementAt(i).ToString(); ;
            }
            if (images.ElementAt(0) != null)
            {
                Image = images.ElementAt(0).ToString();
            }

        }

        public void UpdateLists()
        {
            marks = Marks.Split(',').Select(int.Parse).ToList();
            comments = Comments.Split(';').ToList();
            images = Images.Split(',').ToList();
        }


        public IceCream()
        {

            Id ="essai";
            ShopId = "shop";
           // taste.Add("Chocolate");
          //  images.Add("iceCream_choco.png");
            //comments.Add("");
            Image = "../Image/font_ice_cream.jpg";
            marks.Add(5);
          
            Energy = 70;
            Proteins = 80;
            Calories = 85;
            Description = "";
            
            ///Image = images.ElementAt(0).ToString();
        }

    }
}
