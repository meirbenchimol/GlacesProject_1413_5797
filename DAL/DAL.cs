using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Windows;
using System.Security;
using System.Net;
using System.IO;
using System.Collections;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class Dal
    {

        #region IceCream

        public void AddIceCream(IceCream i)
        {
            using (var db = new IceCreamDB())
            {
                db.IceCreams.Add(i);
                db.SaveChanges();
            }
        }

        public void UpdateIceCream(IceCream pre_IC, IceCream current_IC)
        {


            using (var db = new IceCreamDB())
            {
                if (pre_IC != null)
                {
                    db.IceCreams.Attach(pre_IC);
                    db.IceCreams.Remove(pre_IC);
                    db.SaveChanges();
                }
                db.IceCreams.Add(current_IC);
                db.SaveChanges();
            }

        }


        public bool CheckIceCream(string ID, string ShopID)
        {

            using (var db = new IceCreamDB())
            {

                var query = from m in db.IceCreams
                            where m.Id == ID && m.ShopId == ShopID
                            select m;
                foreach (var item in query)
                    return true;

            }

            return false;

        }

        public IEnumerable<IceCream> GetIceCreamFromShop(string shopid)
        {
            using (var db = new IceCreamDB())
            {
              
                var list =  from i in db.IceCreams
                       where i.ShopId == shopid 
                       select i;

                return list.ToList<IceCream>();
            }

        }





        public IEnumerable<IceCream> GetAllIceCream(Func<IceCream, bool> predicate = null)
        {
            using (var db = new IceCreamDB())
            {
                if (predicate == null)
                    return db.IceCreams.ToList<IceCream>();

                return (IEnumerable<IceCream>)from s in db.IceCreams
                                          where (predicate(s))
                                          select s;
            }
        }


        public IEnumerable<IceCream> FindListIceCream(string taste, string ShopID)
        {

            using (var db = new IceCreamDB())
            {

                var query = from m in db.IceCreams
                            where m.Taste.Contains(taste)
                            && m.ShopId == ShopID
                            select m;
                return query;
            }
        }


        public IEnumerable<IceCream> FindListIceCream(string taste, double energy, double calories, double proteins, double medianmark)
        {

            using (var db = new IceCreamDB())
            {

               


                var query = from m in db.IceCreams
                            where m.Taste.Contains(taste)
                            && (!(energy > (m.Energy + 10)) || (energy < (m.Energy - 10)))
                             && (!(calories > (m.Calories + 10)) || (calories < (m.Calories - 10)))
                              && (!(proteins > (m.Proteins + 10)) || (proteins < (m.Proteins - 10)))
                              /* && /*( ! (Median(m) < medianmark -1)) */
                                              //for the evaluation
                            select m;
                return query.ToList<IceCream>().Where(x=> ! ( Median(x) < medianmark-1));
            }
        }

        public IceCream FindIceCream(string ID, string ShopId)
        {
            using (var db = new IceCreamDB())
            {

                var query = from m in db.IceCreams
                            where m.Id == ID && m.ShopId == ShopId
                            select m;
                return query.FirstOrDefault<IceCream>();
            }

        }





        #endregion


        #region Shops



        public bool CheckShop(string id)
        {


            
            using (var db = new IceCreamDB())
            {
                var query = from m in db.Shops
                            where m.Id == id
                            select m;
                foreach (var item in query)
                {
                    return true;//if we entered here there are items in query,user exist
                }
                return false;


            }


        }

        public IEnumerable<Shop> GetAllShop(Func<Shop, bool> predicate = null)
        {
            using (var db = new IceCreamDB())
            {
                if (predicate == null)
                    return db.Shops.ToList<Shop>();

                return  (IEnumerable < Shop > ) from s in db.Shops
                       where (predicate(s))
                       select s;
            }
        }


        public   void AddShop(Shop s)
        {


            var db = new IceCreamDB();
            db.Shops.Add(s);
            db.SaveChanges();
            /* try
             {
                 using (var db = new IceCreamDB())
                 {
                     db.Shops.Add(s);
                     db.SaveChanges();
                 }
             }
             catch (Exception e)
             {
                 throw new Exception("Erreur");
             }
             */
        }
        public void UpdateShop(Shop pre_shop, Shop current_shop)
        {


            using (var db = new IceCreamDB())
            {
                if (pre_shop != null)//if we get user from main it means he is saved in db..
                {
                    db.Shops.Attach(pre_shop);
                    db.Shops.Remove(pre_shop);
                    db.SaveChanges();
                }
                db.Shops.Add(current_shop);
                db.SaveChanges();
            }


        } 

        public Shop findShopByLogin(String id, string password)
        {
            using (var db = new IceCreamDB())
            {
                var query = from m in db.Shops
                            where m.Id == id && m.Password == password
                            select m;
                foreach (var item in query)
                {
                    return item;//if we entered here there are items in query,user exist
                }
                return null;
            }
        }





        #endregion


        #region helpfunctions


        static double Median(IceCream iceCream)
        {

            int [] marks = iceCream.Marks.Split(',').Select(int.Parse).ToArray();
            return  marks[0];
        }

        #endregion
    }
}
