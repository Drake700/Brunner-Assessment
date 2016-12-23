using BrunnerExercise.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerExercise.Shopping_Cart
{
    public class Offer : IOffer
    {
        //Constructor for the class to implment the ShoppingCart object.
        public Offer()
        {
            ShoppingCart sc = new ShoppingCart();
        }

        //Implement GetTotal_AppleOffer with input paramentor: List with CartItem object
        public decimal GetTotal_AppleOffer(List<CartItem> cartItem)
        {
            //initial the total cost variable
            decimal totalCostofApple;

            //get the number of apple with LINQ
            var numberofApple = cartItem.Where(p => p.ItemId == 1).Select(a => a.Quantity).FirstOrDefault();

            //Calulate the total cost and return a decimal type value follow the business logic
            if (numberofApple >= 2 && numberofApple % 2 == 0)
            {
                totalCostofApple = numberofApple/2 * 0.45M;
            }
            else if (numberofApple >= 2 && numberofApple % 2 != 0)
            {
                totalCostofApple = ((numberofApple-1)/2 + 1) * 0.45M;          
            }
            else
            {
                totalCostofApple = 0.00M;
            }

            return totalCostofApple;

        }

        //Implement GetTotal_OrangeOffer with input paramentor: List with CartItem object
        public decimal GetTotal_OrangeOffer(List<CartItem> cartItem)
        {
            //initial the total cost variable
            decimal totalCostofOrange;

            //get the number of apple with LINQ
            var numberofOrange = cartItem.Where(p => p.ItemId == 2).Select(o => o.Quantity).FirstOrDefault();

            //Calulate the total cost and return a decimal type value follow the business logic
            if (numberofOrange >= 3 && numberofOrange % 3 == 0)
            {
                totalCostofOrange = numberofOrange / 3 * 2 * 0.65M;
            }
            else if (numberofOrange >= 3 && numberofOrange % 3 == 1)
            {
                totalCostofOrange = ((numberofOrange - 1) / 3 * 2 + 1) * 0.65M;
            }
            else if (numberofOrange >= 3 && numberofOrange % 3 == 2)
            {
                totalCostofOrange = ((numberofOrange - 2) / 3 * 2 + 2) * 0.65M;
            }
            else
            {
                totalCostofOrange = 0.00M;
            }

            return totalCostofOrange;
        }
    }
}
