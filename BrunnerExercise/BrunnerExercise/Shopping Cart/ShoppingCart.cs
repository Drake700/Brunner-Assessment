using BrunnerExercise.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerExercise.Shopping_Cart
{
    public class ShoppingCart : IShoppingCart
    {


            //initial all the attributes reqiured
            List<CartItem> cartItem = new List<CartItem>();
        

        //Implement Add Item method
        public void AddItem(List<CartItem> selectItem)
        {
           
            try {

                    if (cartItem.Count == 0)
                    {
                    foreach (var item in selectItem)
                    {

                      cartItem.Add(new CartItem { ItemId = item.ItemId, ItemName = item.ItemName, Quantity = item.Quantity, UnitPrice = item.UnitPrice });

                    }
   
                    }
                    else if (cartItem.Count != 0)
                    {

                    foreach(var product in cartItem)
                    {
                        foreach (var item in selectItem)
                        {
                            if (product.ItemId == item.ItemId)
                            {
                                product.Quantity++;
                            }
                        }
                    }

                    }

            }
            catch
            {

            }

        }

        //Implement Remove Item method
        public void RemoveItem(List<CartItem> removeItem)
        {
            foreach(var product in cartItem)
            {
                foreach (var item in removeItem)
                {
                    if (product.ItemId == item.ItemId)
                    {
                        cartItem.Remove(product);
                    }
                }
            }
        }

        //Implement Update Item method
        public void UpdateQuantity(int updateItem, int numberOfQuantity)
        {
            foreach(var product in cartItem)
            {
                if(product.ItemId == updateItem)
                {
                    product.Quantity = numberOfQuantity;
                }
            }
        }

        //Implement Get total cost 
        public decimal GetTotal(List<CartItem> cartItem, bool AppleOffer, bool OrangeOffer)
        {
            //initial decimal type total cost
            decimal total = 0.00M;

            //Calculate the total cost of item in cart depends on different offer select situation
            if (AppleOffer == false && OrangeOffer == false)
            {
                //without any offers
                foreach (var product in cartItem)
                {
                    total = total + product.UnitPrice * product.Quantity;
                }

            }
            else if(AppleOffer == true && OrangeOffer == false)
            {
                //with Apple offer only

                //get number of Orange with Linq
                var numberofOrange = cartItem.Where(p => p.ItemId == 2).Select(o => o.Quantity).FirstOrDefault();

                //get Unit price of Orange with Linq
                decimal price = cartItem.Where(p => p.ItemId == 2).Select(o => o.UnitPrice).FirstOrDefault();

                //instance the offer class
                Offer of = new Offer();

                //calculate the total follow the business requirement
                total = of.GetTotal_AppleOffer(cartItem) + numberofOrange * price; 
            }
            else if(AppleOffer == false && OrangeOffer == true)
            {
                //with orange offer only

                //get number of Apple with Linq
                var numberofApple = cartItem.Where(p => p.ItemId == 1).Select(a => a.Quantity).FirstOrDefault();

                //get Unit price of Apple with Linq
                decimal price = cartItem.Where(p => p.ItemId == 1).Select(a => a.UnitPrice).FirstOrDefault();

                //instance the offer class
                Offer of = new Offer();

                //calculate the total follow the business requirement
                total = of.GetTotal_OrangeOffer(cartItem) + numberofApple * price;
            }
            else if(AppleOffer == true && OrangeOffer == true)
            {

                //with both apple offer and orange offer
                Offer of = new Offer();

                //calculate the total follow the business requirement
                total = of.GetTotal_AppleOffer(cartItem) + of.GetTotal_OrangeOffer(cartItem);
            }
            else
            {
                //if none return 0
                total = 0.00M;
            }

            return total;

        }



    }
}
