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

        public string[] Taste

        {
            get { return taste.ToArray(); }

            set { Comments = taste.ToArray();
                value = taste.ToArray();
            }

        }



        public List<string> taste = new List<string>();


        //comment test git meir

        static string id = "";

        public string Description { get; set; }


        public string Presentation
        {
            get {
                string s = Id + " " ;
                for (int i = 0; i < Taste.ToList().Count; i++)
                {
                    s +=  Taste[i].ToString();
                    if (i < (Taste.ToList().Count - 1))
                        s += ", " ;
                }
                return s;
            }
        }


        public string[] Images 

        {
            get { return images.ToArray(); }

            set { value = images.ToArray(); }

        }



        public List<string> images = new List<string>();

        public string Image
        {
            get { return images.ElementAt(0).ToString(); }
            set { value = images.ElementAt(0).ToString(); }
        }
        


        public double? Energy { get; set; }

        public double? Proteins { get; set; }

        public double? Calories { get; set; }

        public int[] Marks

        {
            get { return marks.ToArray(); }

            set { value = marks.ToArray(); }

        }



        public List<int> marks = new List<int>();



        public string[] Comments

        {
            get { return comments.ToArray(); }

            set { value = comments.ToArray(); }

        }
    


        public List<string> comments = new List<string>();




        public IceCream()
        {

            Id ="essai";
            ShopId = "shop";
            taste.Add("Chocolate");
            images.Add("iceCream_choco.png");
            comments.Add("");
            marks.Add(5);
            Energy = 70;
            Proteins = 80;
            Calories = 85;
            Description = "";
            ///Image = images.ElementAt(0).ToString();
        }

    }
}
