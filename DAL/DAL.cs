using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

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

                var query1 = from m in db.Shops
                             where (m.Id == i.ShopId)
                             select m;

                var query2 = from m in db.Shops
                             where (m.Id == i.ShopId)
                             select m;

                query2.FirstOrDefault<Shop>().Products.Add(i);


                UpdateShop((Shop)query1, (Shop)query2);
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


        public bool CheckIceCream(int ID, string ShopID)
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

        public IEnumerable<IceCream> GetAllIceCream(Func<IceCream, bool> predicate = null)
        {
            using (var db = new IceCreamDB())
            {
                if (predicate == null)
                    return db.IceCreams;

                return from i in db.IceCreams
                       where (predicate(i))
                       select i;
            }

        }
        public IEnumerable<IceCream> FindListIceCream(Taste taste, string ShopID)
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


        public IEnumerable<IceCream> FindListIceCream(Taste taste, float energy, float calories, float proteins, float minmark, float maxmark)
        {

            using (var db = new IceCreamDB())
            {

                var query = from m in db.IceCreams
                            where m.Taste.Contains(taste)
                            && (!(energy > (m.Energy + 10)) || (energy < (m.Energy - 10)))
                             && (!(calories > (m.Calories + 10)) || (calories < (m.Calories - 10)))
                              && (!(proteins > (m.Proteins + 10)) || (proteins < (m.Proteins - 10)))
                              && (float)m.marks[0] >= minmark && (float)m.marks[m.marks.Count] <= maxmark  //for the evaluation
                            select m;
                return query;
            }
        }

        public IceCream FindIceCream(int ID, string ShopId)
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
                    return db.Shops;

                return from s in db.Shops
                       where (predicate(s))
                       select s;
            }
        }


        public void AddShop(Shop s)
        {
            using (var db = new IceCreamDB())
            {
                db.Shops.Add(s);
                db.SaveChanges();
            }
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
    }
}
