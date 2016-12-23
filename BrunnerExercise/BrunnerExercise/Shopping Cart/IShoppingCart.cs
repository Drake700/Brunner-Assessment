using BrunnerExercise.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerExercise.Shopping_Cart
{
    public interface IShoppingCart
    {
        //Interface for different function and methods for shopping cart

        //add item function
        void AddItem(List<CartItem> selectItem);

        //remove item function
        void RemoveItem(List<CartItem> removeItem);

        //Update item function
        void UpdateQuantity(int updateItem, int numberOfQuantity);

        //get total cost function
        decimal GetTotal(List<CartItem> cartItem, bool AppleOffer, bool OrangeOffer);

    }
}
