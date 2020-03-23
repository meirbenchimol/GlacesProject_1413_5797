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

        public List<Taste> taste = new List<Taste>();

        public List<Taste> Taste
        {
            get { return taste; }
        }
        //comment test git meir


        public string Description { get; set; }


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


        public float? Energy { get; set; }

        public float?  Proteins { get; set; }

        public float? Calories { get; set; }

        public ArrayList marks = new ArrayList();

        private List<string> comments = new List<string>();


        public List<string> Comments
        {
            get { return comments; }

            set { comments = value; }
        }

    }
}
