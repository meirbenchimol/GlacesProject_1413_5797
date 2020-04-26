using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class Bl
    {
        public Dal MyDal { get; set; }


        public Bl()
        {
            MyDal = new Dal();
        }

        #region Shops

        /// <summary>
        /// check if there is already a shop with the same id and password
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns>true if the shop already exists</returns>
        public bool CheckShopExist(string id)
        {
            return MyDal.CheckShop(id);

        }



        /// <summary>
        /// get the shop with this id and this password
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns>The shop with this id and this password</returns>
        public Shop findShopByLogin(string id, string passsword)
        {
            return MyDal.findShopByLogin(id, passsword);
        }

        /// <summary>
        /// update the shop after changes
        /// </summary>
        /// <param name="pre_Shop"></param>
        /// <param name="current_Shop"></param>
        public void UpdateShop(Shop pre_Shop, Shop current_Shop)
        {
            MyDal.UpdateShop(pre_Shop, current_Shop);
        }


        /// <summary>
        /// add the shop 
        /// </summary>
        /// <param name="s"></param>
        public void AddShop(Shop s)
        {
            MyDal.AddShop(s);
        }



        /// <summary>
        /// get the lit of shops with a boolean function in some cases
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>the right list </returns>
        public IEnumerable<Shop> GetAllShop(Func<Shop, bool> predicate = null)
        {
            return MyDal.GetAllShop(predicate);
        }


        #endregion




        #region IceCream

        /// <summary>
        /// add the icecream to the database
        /// </summary>
        /// <param name="IC">the IceCream</param>
        public void AddIceCream(IceCream IC)
        {
            MyDal.AddIceCream(IC);
        }



        /// <summary>
        /// update an icecream in the database
        /// </summary>
        /// <param name="pre_IC">the IceCream before the changes</param>
        /// <param name="current_IceCream"></param>
        public void UpdateIceCream(IceCream pre_IC, IceCream current_IceCream)

        {
            //current_IceCream.marks;
            MyDal.UpdateIceCream(pre_IC, current_IceCream);
        }

        public void DeleteIceCream(IceCream iceCream)
        {
            MyDal.DeleteIceCream(iceCream);
        }


        public IceCream FindIceCream(IceCream iceCream)
        {
            return MyDal.FindIceCream(iceCream.Id, iceCream.ShopId);

        }

        public IEnumerable<IceCream> FindListIceCream(string  taste, double energy, double calories, double proteins, double medianmark)
        {
           


            return MyDal.FindListIceCream( taste, energy, calories, proteins, medianmark);
        }

        public IEnumerable<IceCream> FindListIceCream(string taste, string ShopID)
        {
            return MyDal.FindListIceCream(taste, ShopID);
        }

        public IEnumerable<IceCream> GetIceCreamFromShop(String shopid)
        {
            return MyDal.GetIceCreamFromShop(shopid);
        }


        public IEnumerable<IceCream> GetAllIceCream(Func<IceCream,bool> predicate=null)
        {
            return MyDal.GetAllIceCream(predicate);
        }
        public bool CheckIceCream(string Id, string ShopId)
        {
            return MyDal.CheckIceCream(Id, ShopId);
        }
        #endregion



    }
}
